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
        public delegate object ObjectReader(Buffer buffer);
        public delegate void ObjectWriter(object target, Buffer buffer);

        public delegate ObjectLiaison ObjectLiaisonInstancer(TypeSerializer serializer);

        public class TypeSerializer
        {
            private Type target_type;
            private List<PropInfoEX> target_props;

            private FieldInfo target_field;
            private FieldInfo serializer_field;

            private List<TypeSerializerProp> target_serializer_props;

            ILCastInfo_MakePointer the//generated type be just a data type and generate some delegates that mess with dat shit

            private Type generated_type;
            private ObjectReader reader;
            private ObjectWriter writer;
            private ObjectLiaisonInstancer instancer;

            static private readonly OperationCache<TypeSerializer, Type> GET_OBJECT_LIAISON = new OperationCache<TypeSerializer, Type>(delegate(Type target_type) {
                if (target_type.HasCustomAttributeOfTypeOnAnInstanceMember<ValueAttribute>())
                {
                    return new TypeSerializer(target_type,
                        Filterer_PropInfo.HasCustomAttributeOfType<ValueAttribute>()
                    );
                }

                if (target_type.HasCustomAttributeOfType<SerializableAttribute>(true))
                {
                    return new TypeSerializer(target_type,
                        Filterer_PropInfo.CanSetAndGet(),
                        Filterer_PropInfo.IsSetAndGetPublic()
                    );
                }

                throw new NotSupportedException("Unable to create an TypeSerializer for the type: " + target_type + ".");
            });
            static public TypeSerializer GetTypeSerializer(Type type)
            {
                return GET_OBJECT_LIAISON.Fetch(type);
            }

            static public object ReadObject(Type type, Buffer buffer)
            {
                return GetTypeSerializer(type).Read(buffer);
            }
            static public void WriteObject(object target, Buffer buffer)
            {
                GetTypeSerializer(target.GetTypeEX()).Write(target, buffer);
            }
            static public ObjectLiaison InstanceLiaison(Type type)
            {
                return GetTypeSerializer(type).Instance();
            }

            private ObjectReader CreateReader()
            {
                return GetTargetType().CreateDynamicMethodDelegate<ObjectReader>("ObjectReader", delegate(MethodBase method) {
                    return new ILReturn(
                        GenerateRead(
                            method.GetEffectiveILParameter(0)
                        )
                    );
                });
            }

            private ObjectWriter CreateWriter()
            {
                return GetTargetType().CreateDynamicMethodDelegate<ObjectWriter>("ObjectWriter", delegate(MethodBase method) {
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
                target_field = type_builder.CreateField(GetTargetType(), "target", FieldAttributesExtensions.PRIVATE);
                serializer_field = type_builder.CreateField(typeof(TypeSerializer), "serializer", FieldAttributesExtensions.PRIVATE);

                target_serializer_props = target_props
                    .Convert(p => TypeSerializerProp.Create(type_builder, p, this))
                    .ToList();
            }

            private void CreateConstructor(TypeBuilder type_builder)
            {
                type_builder.CreateConstructor(MethodAttributesExtensions.PUBLIC, delegate(ConstructorBuilderEX method) {
                    return new ILBlock(
                        new ILAssign(method.GetILField(serializer_field), method.GetEffectiveILParameter(0))
                    );
                }, typeof(TypeSerializer));
            }

            private void CreateMethods(TypeBuilder type_builder)
            {
                type_builder.CreateMethod("ReadUpdateInternal", MethodAttributesExtensions.VIRTUAL_PUBLIC, delegate(MethodBuilderEX method) {
                    ILBlock block = new ILBlock();

                    block.AddStatement(new ILAssign(method.GetILField(target_field), method.GetEffectiveILParameter(0)));
                    CreateReadUpdateInternal(method, block, method.GetEffectiveILParameter(1));
                    return block;
                }, typeof(object), typeof(Buffer));

                type_builder.CreateMethod("WriteUpdateInternal", MethodAttributesExtensions.VIRTUAL_PUBLIC, delegate(MethodBuilderEX method) {
                    ILBlock block = new ILBlock();

                    block.AddStatement(new ILAssign(method.GetILField(target_field), method.GetEffectiveILParameter(0)));
                    CreateWriteUpdateInternal(method, block, method.GetEffectiveILParameter(1));
                    return block;
                }, typeof(object), typeof(Buffer));

                type_builder.CreateMethod("GetDeliveryChannel", MethodAttributesExtensions.VIRTUAL_PUBLIC, typeof(int), delegate(MethodBuilderEX method) {
                    return new ILReturn(0);
                });

                type_builder.CreateMethod("GetTarget", MethodAttributesExtensions.VIRTUAL_PUBLIC, typeof(object), delegate(MethodBuilderEX method) {
                    return new ILReturn(method.GetILField(target_field));
                });

                type_builder.CreateMethod("GetTypeSerializer", MethodAttributesExtensions.VIRTUAL_PUBLIC, typeof(TypeSerializer), delegate(MethodBuilderEX method) {
                    return new ILReturn(method.GetILField(serializer_field));
                });
            }
            private void CreateReadUpdateInternal(MethodBase method, ILBlock block, ILValue buffer)
            {
                block.AddStatements(
                    target_serializer_props.Convert(p => p.GenerateRead(method, buffer))
                );
            }
            private void CreateWriteUpdateInternal(MethodBase method, ILBlock block, ILValue buffer)
            {
                block.AddStatements(
                    target_serializer_props.Convert(p => p.GenerateWrite(method, buffer))
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

            private TypeSerializer(Type t, IEnumerable<PropInfoEX> p)
            {
                target_type = t;
                target_props = p.ToList();
            }

            private TypeSerializer(Type t, IEnumerable<Filterer<PropInfoEX>> f) : this(t, t.GetFilteredInstanceProps(f)) { }
            private TypeSerializer(Type t, params Filterer<PropInfoEX>[] f) : this(t, (IEnumerable<Filterer<PropInfoEX>>)f) { }

            public ILValue GenerateRead(ILValue buffer)
            {
                return new ILLoadStatement(delegate(ILBlock block) {
                    ILLocal value = block.CreateLocal(new ILNew(target_type), true);

                    block.AddStatements(
                        target_props
                            .Convert(p => value.GetILProp(p))
                            .Convert(p => ILSerialize.GenerateObjectReadInto(p, buffer))
                    );

                    return value;
                });
            }

            public ILStatement GenerateWrite(ILValue target, ILValue buffer)
            {
                return target_props
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

            public FieldInfo GetTargetField()
            {
                return target_field;
            }

            public FieldInfo GetSerializerField()
            {
                return serializer_field;
            }
        }
    }
}