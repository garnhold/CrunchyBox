using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public delegate object TypeLiaisonReader(Buffer buffer);
        public delegate void TypeLiaisonWriter(object target, Buffer buffer);

        public delegate ObjectLiaison ObjectLiaisonInstancer(TypeLiaison liaison);

        public class TypeLiaison
        {
            private Type target_type;
            private List<PropInfoEX> target_type_props;

            private FieldInfo field_target;
            private FieldInfo field_liaison;

            private List<PropInfoEX> target_simple_props;
            private List<TypeLiaisonProp> target_liaison_instance_props;

            private Type generated_type;
            private TypeLiaisonReader reader;
            private TypeLiaisonWriter writer;
            private ObjectLiaisonInstancer instancer;

            static private readonly OperationCache<TypeLiaison, Type> GET_OBJECT_LIAISON = new OperationCache<TypeLiaison, Type>(delegate(Type target_type) {
                if (target_type.HasCustomAttributeOfTypeOnAnInstanceMember<ValueAttribute>())
                {
                    return new TypeLiaison(target_type,
                        Filterer_PropInfo.HasCustomAttributeOfType<ValueAttribute>()
                    );
                }

                if (target_type.HasCustomAttributeOfType<SerializableAttribute>(true))
                {
                    return new TypeLiaison(target_type,
                        Filterer_PropInfo.CanSetAndGet(),
                        Filterer_PropInfo.IsSetAndGetPublic()
                    );
                }

                throw new NotSupportedException("Unable to create an TypeLiaison for the type: " + target_type + ".");
            });
            static public TypeLiaison GetObjectLiaison(Type type)
            {
                return GET_OBJECT_LIAISON.Fetch(type);
            }

            static public object ReadLiaison(Type type, Buffer buffer)
            {
                return GetObjectLiaison(type).Read(buffer);
            }
            static public void WriteLiaison(object target, Buffer buffer)
            {
                GetObjectLiaison(target.GetTypeEX()).Write(target, buffer);
            }
            static public ObjectLiaison InstanceLiaison(Type type)
            {
                return GetObjectLiaison(type).Instance();
            }

            private TypeLiaisonReader CreateReader()
            {
                return GetTargetType().CreateDynamicMethodDelegate<TypeLiaisonReader>("TypeLiaisonReader", delegate(MethodBase method) {
                    return new ILReturn(
                        GenerateRead(
                            method.GetEffectiveILParameter(0)
                        )
                    );
                });
            }

            private TypeLiaisonWriter CreateWriter()
            {
                return GetTargetType().CreateDynamicMethodDelegate<TypeLiaisonWriter>("TypeLiaisonWriter", delegate(MethodBase method) {
                    return GenerateWrite(
                        method.GetEffectiveILParameter(0),
                        method.GetEffectiveILParameter(1)
                    );
                });
            }

            private ObjectLiaisonInstancer CreateInstancer()
            {
                return GetTargetType().CreateDynamicMethodDelegate<ObjectLiaisonInstancer>("ObjectLiaisonInstancer", delegate(MethodBase method) {
                    return new ILReturn(
                        new ILNew(
                            GetGeneratedType(),
                            method.GetTechnicalILParameter(0)
                        )
                    );
                });
            }

            private void CreateFields(TypeBuilder type_builder)
            {
                field_target = type_builder.CreateField(GetTargetType(), "target", FieldAttributesExtensions.PRIVATE);
                field_liaison = type_builder.CreateField(typeof(TypeLiaison), "liaison", FieldAttributesExtensions.PRIVATE);

                target_simple_props = target_type_props.ToList();

                target_liaison_instance_props = target_simple_props.Extract(p => p.HasCustomAttributeOfType<UseLiaisonAttribute>(true))
                    .Convert(p => new TypeLiaisonProp(type_builder, p))
                    .ToList();
            }

            private void CreateConstructor(TypeBuilder type_builder)
            {
                type_builder.CreateConstructor(MethodAttributesExtensions.PUBLIC, delegate(ConstructorBuilder method) {
                    return new ILBlock(
                        new ILAssign(method.GetILField(field_liaison), method.GetEffectiveILParameter(1))
                    );
                }, typeof(TypeLiaison));
            }

            private void CreateMethods(TypeBuilder type_builder)
            {
                type_builder.CreateMethod("ReadUpdateInternal", MethodAttributesExtensions.VIRTUAL_PUBLIC, delegate(MethodBuilder method) {
                    ILBlock block = new ILBlock();

                    block.AddStatement(new ILAssign(method.GetILField(field_target), method.GetEffectiveILParameter(0)));
                    CreateReadUpdateInternal(method, block, method.GetEffectiveILParameter(1));
                    return block;
                }, typeof(object), typeof(Buffer));

                type_builder.CreateMethod("WriteUpdateInternal", MethodAttributesExtensions.VIRTUAL_PUBLIC, delegate(MethodBuilder method) {
                    ILBlock block = new ILBlock();

                    block.AddStatement(new ILAssign(method.GetILField(field_target), method.GetEffectiveILParameter(0)));
                    CreateWriteUpdateInternal(method, block, method.GetEffectiveILParameter(0));
                    return block;
                }, typeof(object), typeof(Buffer));

                type_builder.CreateMethod("GetTarget", MethodAttributesExtensions.VIRTUAL_PUBLIC, typeof(object), delegate(MethodBuilder method) {
                    return new ILReturn(method.GetILField(field_target));
                });
            }
            private void CreateReadUpdateInternal(MethodBase method, ILBlock block, ILValue buffer)
            {
                block.AddStatements(
                    target_simple_props
                        .Convert(p => method.GetILProp(p))
                        .Convert(p => ILSerialize.GenerateObjectReadInto(p, buffer))
                );

                block.AddStatements(
                    target_liaison_instance_props
                        .Convert(p => p.GenerateRead(method, buffer))
                );
            }
            private void CreateWriteUpdateInternal(MethodBase method, ILBlock block, ILValue buffer)
            {
                block.AddStatements(
                    target_simple_props
                        .Convert(p => method.GetILProp(p))
                        .Convert(p => ILSerialize.GenerateObjectWrite(p, buffer))
                );

                block.AddStatements(
                    target_liaison_instance_props
                        .Convert(p => p.GenerateWrite(method, buffer))
                );
            }

            private Type CreateType()
            {
                return TypeCreator.CreateType("ObjectLiaison_" + GetTargetType().Name, TypeAttributesExtensions.PUBLIC_CLASS, delegate(TypeBuilder type_builder) {
                    type_builder.SetParent(typeof(ObjectLiaison));

                    CreateFields(type_builder);
                    CreateConstructor(type_builder);
                    CreateMethods(type_builder);
                });
            }

            private TypeLiaison(Type t, IEnumerable<PropInfoEX> p)
            {
                target_type = t;
                target_type_props = p.ToList();
            }

            private TypeLiaison(Type t, IEnumerable<Filterer<PropInfoEX>> f) : this(t, t.GetFilteredInstanceProps(f)) { }
            private TypeLiaison(Type t, params Filterer<PropInfoEX>[] f) : this(t, (IEnumerable<Filterer<PropInfoEX>>)f) { }

            public ILValue GenerateRead(ILValue buffer)
            {
                return new ILLoadStatement(delegate(ILBlock block) {
                    ILLocal value = block.CreateLocal(new ILNew(target_type), true);

                    block.AddStatements(
                        target_type_props
                            .Convert(p => value.GetILProp(p))
                            .Convert(p => ILSerialize.GenerateObjectReadInto(p, buffer))
                    );

                    return value;
                });
            }

            public ILStatement GenerateWrite(ILValue target, ILValue buffer)
            {
                return target_type_props
                    .Convert(p => target.GetILProp(p))
                    .Convert(p => ILSerialize.GenerateObjectWrite(p, buffer))
                    .ToBlock();
            }

            public object Read(Buffer buffer)
            {
                if (reader != null)
                    reader = CreateReader();

                return reader(buffer);
            }

            public void Write(object target, Buffer buffer)
            {
                if (writer != null)
                    writer = CreateWriter();

                writer(target, buffer);
            }

            public ObjectLiaison Instance()
            {
                if (instancer == null)
                    instancer = CreateInstancer();

                return instancer(this);
            }

            public Type GetGeneratedType()
            {
                if (generated_type == null)
                    generated_type = CreateType();

                return generated_type;
            }

            public Type GetTargetType()
            {
                return target_type;
            }
        }
    }
}