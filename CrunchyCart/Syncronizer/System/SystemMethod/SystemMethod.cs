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
        public abstract class SystemMethodAttribute : Attribute
        {
            public abstract SystemMethod CreateSystemMethod(MethodInfo method);
        }

        public abstract class SystemMethod : Invokable
        {
            public abstract void ReadMethodInvoke(System system, Buffer buffer);
            public abstract void SendMethodInvoke(System system, object[] arguments);

            static private OperationCache<SystemMethod, MethodInfo> GET_SYSTEM_METHOD = new OperationCache<SystemMethod, MethodInfo>("GET_SYSTEM_METHOD", delegate(MethodInfo method) {
                return method.GetCustomAttributeOfType<SystemMethodAttribute>(true).CreateSystemMethod(method);
            });
            static public SystemMethod GetSystemMethod(MethodInfo method)
            {
                return GET_SYSTEM_METHOD.Fetch(method);
            }

            static private OperationCache<SystemMethod, Type, string> GET_SYSTEM_METHOD_BY_SIGNATURE = new OperationCache<SystemMethod, Type, string>("GET_SYSTEM_METHOD_BY_SIGNATURE", delegate(Type type, string name) {
                return GetSystemMethod(
                    type.GetFilteredInstanceMethods(
                        Filterer_MethodInfo.IsNamed(name),
                        Filterer_MethodInfo.HasCustomAttributeOfType<SystemMethodAttribute>()
                    ).GetFirst()
                );
            });
            static public SystemMethod GetSystemMethodBySignature(Type type, string name)
            {
                return GET_SYSTEM_METHOD_BY_SIGNATURE.Fetch(type, name);
            }

            public SystemMethod(MethodInfo m) : base(m)
            {
            }
        }
    }
}