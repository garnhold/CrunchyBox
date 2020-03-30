using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public class MethodInfoEX : MethodInfoPass
    {
        private MethodInfo native_method_info;

        private BasicMethodInvoker basic_method_invoker;

        static private OperationCache<MethodInfoEX, MethodInfo> GET_METHOD_INFO_EX = ReflectionCache.Get().NewOperationCache("GET_METHOD_INFO_EX", delegate(MethodInfo method_info) {
            return new MethodInfoEX(method_info);
        });
        static public MethodInfoEX GetMethodInfoEX(MethodInfo method_info)
        {
            MethodInfoEX cast;

            if (method_info != null)
            {
                if (method_info.Convert<MethodInfoEX>(out cast))
                    return cast;

                return GET_METHOD_INFO_EX.Fetch(method_info);
            }

            return null;
        }

        protected MethodInfoEX(MethodInfo m)
        {
            native_method_info = m;
        }

        public override MethodInfo GetNativeMethodInfo()
        {
            return native_method_info;
        }

        public BasicMethodInvoker GetBasicMethodInvoker()
        {
            if (basic_method_invoker == null)
                basic_method_invoker = GetNativeMethodInfo().CreateDynamicEffectiveMethodInvokerDelegate<BasicMethodInvoker>();

            return basic_method_invoker;
        }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            return GetBasicMethodInvoker()(obj, parameters);
        }
    }
}