using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ConstructorInfoEX : ConstructorInfoPass
    {
        private ConstructorInfo native_constructor_info;
        private BasicConstructorInvoker basic_constructor_invoker;
        private BasicMethodInvoker basic_method_invoker;

        static private OperationCache<ConstructorInfoEX, ConstructorInfo> GET_CONSTRUCTOR_INFO_EX = ReflectionCache.Get().NewOperationCache("GET_CONSTRUCTOR_INFO_EX", delegate(ConstructorInfo constructor_info) {
            return new ConstructorInfoEX(constructor_info);
        });
        static public ConstructorInfoEX GetConstructorInfoEX(ConstructorInfo constructor_info)
        {
            ConstructorInfoEX cast;

            if (constructor_info != null)
            {
                if (constructor_info.Convert<ConstructorInfoEX>(out cast))
                    return cast;

                return GET_CONSTRUCTOR_INFO_EX.Fetch(constructor_info);
            }

            return null;
        }

        protected ConstructorInfoEX(ConstructorInfo c)
        {
            native_constructor_info = c;
        }

        public override ConstructorInfo GetNativeConstructorInfo()
        {
            return native_constructor_info;
        }

        public BasicConstructorInvoker GetBasicConstructorInvoker()
        {
            if (basic_constructor_invoker == null)
                basic_constructor_invoker = native_constructor_info.CreateDynamicConstructorInvokerDelegate<BasicConstructorInvoker>();

            return basic_constructor_invoker;
        }

        public BasicMethodInvoker GetBasicMethodInvoker()
        {
            if (basic_method_invoker == null)
            {
                basic_method_invoker = delegate(object obj, object[] parameters) {
                    return GetBasicConstructorInvoker()(parameters);
                };
            }

            return basic_method_invoker;
        }

        public ConstructorInvoker<T> GetConstructorInvoker<T>()
        {
            return GetBasicConstructorInvoker().GetTypeSafe<T>();
        }

        public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            return GetBasicConstructorInvoker()(parameters);
        }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            return GetBasicConstructorInvoker()(parameters);
        }
    }
}