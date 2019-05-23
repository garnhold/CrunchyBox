using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class MethodInfoEX : MethodInfoPass
    {
        private MethodInfo native_method_info;

        private BasicMethodInvoker basic_method_invoker;

        static private OperationCache<MethodInfoEX, MethodInfo> GET_METHOD_INFO_EX = ReflectionCache.Get().NewOperationCache(delegate(MethodInfo method_info) {
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
                basic_method_invoker = GetNativeMethodInfo().CreateDynamicMethodInvokerDelegate<BasicMethodInvoker>();

            return basic_method_invoker;
        }
        public MethodInvoker GetMethodInvoker()
        {
            return GetBasicMethodInvoker().GetTypeSafeNoReturn();
        }
        public MethodInvoker<T> GetMethodInvoker<T>()
        {
            return GetBasicMethodInvoker().GetTypeSafe<T>();
        }

        public BasicValueGetter GetSimulatedBasicValueGetter()
        {
            return GetBasicMethodInvoker().GetSimulatedBasicValueGetter();
        }

        public BasicValueSetter GetSimulatedBasicValueSetter()
        {
            return GetBasicMethodInvoker().GetSimulatedBasicValueSetter();
        }

        public ValueGetter<T> GetSimulatedValueGetter<T>()
        {
            return GetBasicMethodInvoker().GetSimulatedValueGetter<T>();
        }

        public ValueSetter<T> GetSimulatedValueSetter<T>()
        {
            return GetBasicMethodInvoker().GetSimulatedValueSetter<T>();
        }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            return GetBasicMethodInvoker()(obj, parameters);
        }
    }
}