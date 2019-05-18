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

        public delegate void ObjectLiaisonReader(object target, object liaison, Buffer buffer);
        public delegate void ObjectLiaisonWriter(object target, object liaison, Buffer buffer);

        public delegate ObjectLiaison ObjectLiaisonInstancer(TypeSerializer serializer);

        public class TypeSerializer
        {
            private Type target_type;
            private List<PropInfoEX> target_props;

            private List<TypeSerializerProp> target_serializer_props;

            private ObjectReader object_reader;
            private ObjectWriter object_writer;

            private Type liaison_type;
            private ObjectLiaisonReader object_liaison_reader;
            private ObjectLiaisonWriter object_liaison_writer;
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
                if (object_reader != null)
                {
                    object_reader = GetTargetType().CreateDynamicMethodDelegate<ObjectReader>(delegate(ILValue il_buffer) {
                        return new ILReturn(GenerateRead(il_buffer));
                    });
                }

                return object_reader(buffer);
            }
            public void Write(object target, Buffer buffer)
            {
                if (object_writer != null)
                {
                    object_writer = GetTargetType().CreateDynamicMethodDelegateWithForcedParameterTypes<ObjectWriter>(delegate(ILValue il_target, ILValue il_buffer) {
                        return GenerateWrite(il_target, il_buffer);
                    }, GetTargetType(), typeof(Buffer));
                }

                object_writer(target, buffer);
            }

            public void Read(object target, object liaison, Buffer buffer)
            {
                if (object_liaison_reader == null)
                {
                    object_liaison_reader = GetTargetType().CreateDynamicMethodDelegateWithForcedParameterTypes<ObjectLiaisonReader>(delegate(ILValue il_target, ILValue il_liaison, ILValue il_buffer) {
                        return target_serializer_props
                            .Convert(p => p.GenerateRead(il_target, il_liaison, il_buffer))
                            .ToBlock();
                    }, GetTargetType(), GetLiaisonType(), typeof(Buffer));
                }

                object_liaison_reader(target, liaison, buffer);
            }
            public void Write(object target, object liaison, Buffer buffer)
            {
                if (object_liaison_writer == null)
                {
                    object_liaison_writer = GetTargetType().CreateDynamicMethodDelegateWithForcedParameterTypes<ObjectLiaisonWriter>(delegate(ILValue il_target, ILValue il_liaison, ILValue il_buffer) {
                        return target_serializer_props
                            .Convert(p => p.GenerateWrite(il_target, il_liaison, il_buffer))
                            .ToBlock();
                    }, GetTargetType(), GetLiaisonType(), typeof(Buffer));
                }

                object_liaison_writer(target, liaison, buffer);
            }

            public ObjectLiaison Instance()
            {
                if (instancer == null)
                {
                    instancer = GetTargetType().CreateDynamicMethodDelegate<ObjectLiaisonInstancer>(delegate(ILValue il_serializer) {
                        return new ILReturn(new ILNew(GetLiaisonType(), il_serializer));
                    });
                }

                return instancer(this);
            }

            public Type GetTargetType()
            {
                return target_type;
            }

            public Type GetLiaisonType()
            {
                if (liaison_type == null)
                {
                    liaison_type = TypeCreator.CreateType("ObjectLiaison_" + GetTargetType().Name, TypeAttributesExtensions.PUBLIC_CLASS, delegate(TypeBuilder type_builder) {
                        type_builder.SetParent(typeof(ObjectLiaison));

                        target_serializer_props = target_props
                            .Convert(p => TypeSerializerProp.Create(type_builder, p, this))
                            .ToList();

                        type_builder.CreateConstructor(MethodAttributesExtensions.PUBLIC, delegate(ConstructorBuilderEX method) {
                            return method.GetBaseILConstruct(method.GetEffectiveILParameter(0));
                        }, typeof(TypeSerializer));
                    });
                }

                return liaison_type;
            }
        }
    }
}