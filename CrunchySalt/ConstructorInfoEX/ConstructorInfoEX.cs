using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class ConstructorInfoEX : ConstructorInfo, ForeignConstructorInfo
    {
        private ConstructorInfo native_constructor_info;
        private BasicConstructorInvoker basic_constructor_invoker;
        private BasicMethodInvoker basic_method_invoker;

        static private OperationCache<ConstructorInfoEX, ConstructorInfo> GET_CONSTRUCTOR_INFO_EX = ReflectionCache.Get().NewOperationCache(delegate(ConstructorInfo constructor_info) {
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

        private ConstructorInfoEX(ConstructorInfo c)
        {
            native_constructor_info = c;
        }

        public ConstructorInfo GetNativeConstructorInfo()
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

        public override string ToString()
        {
            return DeclaringType.ToString() + "(" + GetParameters().ToString(",") + ")";
        }

        //ConstructorInfo
        public override MemberTypes MemberType { get{ return native_constructor_info.MemberType; } }
        public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            return GetBasicConstructorInvoker()(parameters);
        }

        //MethodBase
        public override MethodAttributes Attributes { get { return native_constructor_info.Attributes; } }
        public override CallingConventions CallingConvention { get { return native_constructor_info.CallingConvention; } }
        public override bool ContainsGenericParameters { get { return native_constructor_info.ContainsGenericParameters; } }
        public override bool IsGenericMethod { get { return native_constructor_info.IsGenericMethod; } }
        public override bool IsGenericMethodDefinition { get { return native_constructor_info.IsGenericMethodDefinition; } }
        public override RuntimeMethodHandle MethodHandle { get { return native_constructor_info.MethodHandle; } }
        public override Type[] GetGenericArguments() { return native_constructor_info.GetGenericArguments(); }
        public override MethodBody GetMethodBody() { return native_constructor_info.GetMethodBody(); }
        public override MethodImplAttributes GetMethodImplementationFlags() { return native_constructor_info.GetMethodImplementationFlags(); }
        public override ParameterInfo[] GetParameters() { return native_constructor_info.GetParameters(); }
        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            return GetBasicConstructorInvoker()(parameters);
        }

        //MemberInfo
        public override Type DeclaringType { get { return native_constructor_info.DeclaringType; } }
        public override int MetadataToken { get { return native_constructor_info.MetadataToken; } }
        public override Module Module { get { return native_constructor_info.Module; } }
        public override string Name { get { return native_constructor_info.Name; } }
        public override Type ReflectedType { get { return native_constructor_info.ReflectedType; } }

        public override object[] GetCustomAttributes(bool inherit) { return native_constructor_info.GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return native_constructor_info.GetCustomAttributes(attributeType, inherit); }
        public override bool IsDefined(Type attributeType, bool inherit) { return native_constructor_info.IsDefined(attributeType, inherit); }
    }
}