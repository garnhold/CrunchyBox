using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        [AttributeUsage(AttributeTargets.Method)]
        public abstract class EntityMethodAttribute : Attribute
        {
            public abstract EntityMethod CreateEntityMethod(MethodInfo method);
        }

        public abstract class EntityMethod : Invokable
        {
            public abstract void ReadMethodInvoke(Entity entity, Buffer buffer);
            public abstract void SendMethodInvoke(Entity entity, object[] arguments);

            static private OperationCache<EntityMethod, MethodInfo> GET_ENTITY_METHOD = new OperationCache<EntityMethod, MethodInfo>("GET_ENTITY_METHOD", delegate(MethodInfo method) {
                return method.GetCustomAttributeOfType<EntityMethodAttribute>(true).CreateEntityMethod(method);
            });
            static public EntityMethod GetEntityMethod(MethodInfo method)
            {
                return GET_ENTITY_METHOD.Fetch(method);
            }

            static private OperationCache<EntityMethod, Type, string> GET_ENTITY_METHOD_BY_SIGNATURE = new OperationCache<EntityMethod, Type, string>("GET_ENTITY_METHOD_BY_SIGNATURE", delegate(Type type, string name) {
                return GetEntityMethod(
                    type.GetFilteredInstanceMethods(
                        Filterer_MethodInfo.IsNamed(name),
                        Filterer_MethodInfo.HasCustomAttributeOfType<EntityMethodAttribute>()
                    ).GetFirst()
                );
            });
            static public EntityMethod GetEntityMethodBySignature(Type type, string name)
            {
                return GET_ENTITY_METHOD_BY_SIGNATURE.Fetch(type, name);
            }

            public EntityMethod(MethodInfo m) : base(m)
            {
            }
        }
    }
}