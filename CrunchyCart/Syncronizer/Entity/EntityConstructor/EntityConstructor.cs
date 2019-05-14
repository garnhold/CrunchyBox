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
        [AttributeUsage(AttributeTargets.Method)]
        public abstract class ConstructorAttribute : Attribute
        {
            public abstract EntityConstructor CreateEntityConstructor(MethodInfo method);
        }

        public abstract class EntityConstructor : EntityInvokable
        {
            public abstract void ReadConstructorInvoke(Syncronizer syncronizer, Buffer buffer);
            public abstract void SendConstructorInvoke(Syncronizer syncronizer, object[] arguments);
            public abstract void SendConstructorReplay(Syncronizer syncronizer, NetworkRecipient recipient, object[] arguments, Entity spawned_entity);

            static private OperationCache<EntityConstructor, MethodInfo> GET_ENTITY_CONSTRUCTOR = new OperationCache<EntityConstructor, MethodInfo>(delegate(MethodInfo method) {
                return method.GetCustomAttributeOfType<ConstructorAttribute>(true).CreateEntityConstructor(method);
            });
            static public EntityConstructor GetEntityConstructor(MethodInfo method)
            {
                return GET_ENTITY_CONSTRUCTOR.Fetch(method);
            }

            static private OperationCache<EntityConstructor, Type, string> GET_ENTITY_CONSTRUCTOR_BY_SIGNATURE = new OperationCache<EntityConstructor, Type, string>(delegate(Type type, string name) {
                return GetEntityConstructor(
                    type.GetFilteredStaticMethods(
                        Filterer_MethodInfo.IsNamed(name),
                        Filterer_MethodInfo.HasCustomAttributeOfType<ConstructorAttribute>()
                    ).GetFirst()
                );
            });
            static public EntityConstructor GetEntityConstructorBySignature(Type type, string name)
            {
                return GET_ENTITY_CONSTRUCTOR_BY_SIGNATURE.Fetch(type, name);
            }

            public EntityConstructor(MethodInfo m) : base(m)
            {
            }
        }
    }
}