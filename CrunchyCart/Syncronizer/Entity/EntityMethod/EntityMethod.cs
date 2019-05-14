﻿using System;
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
        public abstract class MethodAttribute : Attribute
        {
            public abstract EntityMethod CreateEntityMethod(MethodInfo method);
        }

        public abstract class EntityMethod : EntityInvokable
        {
            public abstract void ReadMethodInvoke(Entity entity, Buffer buffer);
            public abstract void SendMethodInvoke(Entity entity, object[] arguments);

            static private OperationCache<EntityMethod, MethodInfo> GET_ENTITY_METHOD = new OperationCache<EntityMethod, MethodInfo>(delegate(MethodInfo method) {
                return method.GetCustomAttributeOfType<MethodAttribute>(true).CreateEntityMethod(method);
            });
            static public EntityMethod GetEntityMethod(MethodInfo method)
            {
                return GET_ENTITY_METHOD.Fetch(method);
            }

            static private OperationCache<EntityMethod, Type, string> GET_ENTITY_METHOD_BY_SIGNATURE = new OperationCache<EntityMethod, Type, string>(delegate(Type type, string name) {
                return GetEntityMethod(
                    type.GetFilteredInstanceMethods(
                        Filterer_MethodInfo.IsNamed(name),
                        Filterer_MethodInfo.HasCustomAttributeOfType<MethodAttribute>()
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