using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class MethodInfoEX : MethodInfo, ForeignMethodInfo
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

        public MethodInfo GetNativeMethodInfo()
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

        public override string ToString()
        {
            return ReturnType.ToString() + " " + Name + "(" + GetParameters().ToString(",") + ")";
        }

        //MethodInfo
        public override MemberTypes MemberType { get { return native_method_info.MemberType; } }
        public override ParameterInfo ReturnParameter { get { return native_method_info.ReturnParameter; } }
        public override Type ReturnType { get { return native_method_info.ReturnType; } }
        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get { return native_method_info.ReturnTypeCustomAttributes; } }
        //public override Delegate CreateDelegate(Type delegateType) { return method_info.CreateDelegate(delegateType); }
        //public override Delegate CreateDelegate(Type delegateType, object target) { return method_info.CreateDelegate(delegateType, target); }
        public override bool Equals(object obj)
        {
            MethodInfo method_info = obj as MethodInfo;

            if (method_info != null)
                return native_method_info.Equals(method_info.GetNativeMethodInfo());

            return false;
        }
        public override MethodInfo GetBaseDefinition() { return native_method_info.GetBaseDefinition(); }
        public override Type[] GetGenericArguments() { return native_method_info.GetGenericArguments(); }
        public override MethodInfo GetGenericMethodDefinition() { return native_method_info.GetGenericMethodDefinition(); }
        public override int GetHashCode() { return native_method_info.GetHashCode(); }
        public override MethodInfo MakeGenericMethod(params Type[] typeArguments) { return native_method_info.MakeGenericMethod(typeArguments); }

        //MethodBase
        public override MethodAttributes Attributes { get { return native_method_info.Attributes; } }
        public override CallingConventions CallingConvention { get { return native_method_info.CallingConvention; } }
        public override bool ContainsGenericParameters { get { return native_method_info.ContainsGenericParameters; } }
        public override bool IsGenericMethod { get { return native_method_info.IsGenericMethod; } }
        public override bool IsGenericMethodDefinition { get { return native_method_info.IsGenericMethodDefinition; } }
        //public override bool IsSecurityCritical { get { return method_info.IsSecurityCritical; } }
        //public override bool IsSecuritySafeCritical { get { return method_info.IsSecuritySafeCritical; } }
        //public override bool IsSecurityTransparent { get { return method_info.IsSecurityTransparent; } }
        public override RuntimeMethodHandle MethodHandle { get { return native_method_info.MethodHandle; } }
        //public override MethodImplAttributes MethodImplementationFlags { get { return method_info.MethodImplementationFlags; } }
        public override MethodBody GetMethodBody() { return native_method_info.GetMethodBody(); }
        public override MethodImplAttributes GetMethodImplementationFlags() { return native_method_info.GetMethodImplementationFlags(); }
        public override ParameterInfo[] GetParameters() { return native_method_info.GetParameters(); }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
        {
            return GetBasicMethodInvoker()(obj, parameters);
        }

        //MemberInfo
        //public override IEnumerable<CustomAttributeData> CustomAttributes { get { return method_info.CustomAttributes; } }
        public override Type DeclaringType { get { return native_method_info.DeclaringType; } }
        public override int MetadataToken { get { return native_method_info.MetadataToken; } }
        public override Module Module { get { return native_method_info.Module; } }
        public override string Name { get { return native_method_info.Name; } }
        public override Type ReflectedType { get { return native_method_info.ReflectedType; } }
        public override object[] GetCustomAttributes(bool inherit) { return native_method_info.GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return native_method_info.GetCustomAttributes(attributeType, inherit); }
        //public override IList<CustomAttributeData> GetCustomAttributesData() { return method_info.GetCustomAttributesData(); }
        public override bool IsDefined(Type attributeType, bool inherit) { return native_method_info.IsDefined(attributeType, inherit); }
    }
}