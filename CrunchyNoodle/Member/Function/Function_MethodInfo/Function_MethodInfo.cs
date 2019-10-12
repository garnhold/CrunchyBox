using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Function_MethodInfo : Function
    {
        private string name;
        private BasicMethodInvoker invoker;

        private MethodInfo method;

        static public Function_MethodInfo New(Type type, string name, IEnumerable<Type> parameter_types)
        {
            MethodInfoEX method = type.GetInstanceMethod(name, parameter_types);

            if (method != null)
                return new Function_MethodInfo(method);

            return null;
        }
        static public Function_MethodInfo New(Type type, string name, params Type[] parameter_types)
        {
            return New(type, name, (IEnumerable<Type>)parameter_types);
        }

        static public Function_MethodInfo New(string name, PathResolver path_resolver, IEnumerable<Type> parameter_types)
        {
            MethodInfoEX method = path_resolver.GetOutputType().GetInstanceMethod(name, parameter_types);

            if (method != null)
                return new Function_MethodInfo(method);

            return null;
        }
        static public Function_MethodInfo New(string name, PathResolver path_resolver, params Type[] parameter_types)
        {
            return New(name, path_resolver, (IEnumerable<Type>)parameter_types);
        }

        protected override object ExecuteInternal(object target, object[] arguments)
        {
            if (invoker != null)
                return invoker(target, arguments);

            return null;
        }

        protected override string GetFunctionNameInternal()
        {
            return name;
        }

        protected override IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit)
        {
            return method.GetAllCustomAttributes(inherit);
        }

        public Function_MethodInfo(MethodInfoEX m)
            : base(
                m.IfNotNull(z => z.DeclaringType),
                m.IfNotNull(z => z.ReturnType),
                m.IfNotNull(z => z.GetEffectiveParameters().Convert(p => KeyValuePair.New(p.Name, p.ParameterType)))
            )
        {
            name = m.IfNotNull(z => z.Name);
            invoker = m.IfNotNull(z => z.GetBasicMethodInvoker());

            method = m;
        }
    }
}