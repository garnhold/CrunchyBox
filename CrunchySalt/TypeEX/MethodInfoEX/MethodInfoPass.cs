using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class MethodInfoPass : MethodInfo, ForeignMethodInfo
    {
        public abstract MethodInfo GetNativeMethodInfo();

        public override string ToString()
        {
            return ReturnType.ToString() + " " + Name + "(" + GetParameters().ToString(",") + ")";
        }

        //MethodInfo
        public override MemberTypes MemberType { get { return GetNativeMethodInfo().MemberType; } }
        public override ParameterInfo ReturnParameter { get { return GetNativeMethodInfo().ReturnParameter; } }
        public override Type ReturnType { get { return GetNativeMethodInfo().ReturnType; } }
        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get { return GetNativeMethodInfo().ReturnTypeCustomAttributes; } }
        //public override Delegate CreateDelegate(Type delegateType) { return method_info.CreateDelegate(delegateType); }
        //public override Delegate CreateDelegate(Type delegateType, object target) { return method_info.CreateDelegate(delegateType, target); }
        
        public override MethodInfo GetBaseDefinition() { return GetNativeMethodInfo().GetBaseDefinition(); }
        public override Type[] GetGenericArguments() { return GetNativeMethodInfo().GetGenericArguments(); }
        public override MethodInfo GetGenericMethodDefinition() { return GetNativeMethodInfo().GetGenericMethodDefinition(); }
        public override MethodInfo MakeGenericMethod(params Type[] typeArguments) { return GetNativeMethodInfo().MakeGenericMethod(typeArguments); }

        //MethodBase
        public override MethodAttributes Attributes { get { return GetNativeMethodInfo().Attributes; } }
        public override CallingConventions CallingConvention { get { return GetNativeMethodInfo().CallingConvention; } }
        public override bool ContainsGenericParameters { get { return GetNativeMethodInfo().ContainsGenericParameters; } }
        public override bool IsGenericMethod { get { return GetNativeMethodInfo().IsGenericMethod; } }
        public override bool IsGenericMethodDefinition { get { return GetNativeMethodInfo().IsGenericMethodDefinition; } }
        //public override bool IsSecurityCritical { get { return method_info.IsSecurityCritical; } }
        //public override bool IsSecuritySafeCritical { get { return method_info.IsSecuritySafeCritical; } }
        //public override bool IsSecurityTransparent { get { return method_info.IsSecurityTransparent; } }
        public override RuntimeMethodHandle MethodHandle { get { return GetNativeMethodInfo().MethodHandle; } }
        //public override MethodImplAttributes MethodImplementationFlags { get { return method_info.MethodImplementationFlags; } }
        public override MethodBody GetMethodBody() { return GetNativeMethodInfo().GetMethodBody(); }
        public override MethodImplAttributes GetMethodImplementationFlags() { return GetNativeMethodInfo().GetMethodImplementationFlags(); }
        public override ParameterInfo[] GetParameters() { return GetNativeMethodInfo().GetParameters(); }

        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { return GetNativeMethodInfo().Invoke(obj, invokeAttr, binder, parameters, culture); }

        //MemberInfo
        //public override IEnumerable<CustomAttributeData> CustomAttributes { get { return method_info.CustomAttributes; } }
        public override Type DeclaringType { get { return GetNativeMethodInfo().DeclaringType; } }
        public override int MetadataToken { get { return GetNativeMethodInfo().MetadataToken; } }
        public override Module Module { get { return GetNativeMethodInfo().Module; } }
        public override string Name { get { return GetNativeMethodInfo().Name; } }
        public override Type ReflectedType { get { return GetNativeMethodInfo().ReflectedType; } }
        public override object[] GetCustomAttributes(bool inherit) { return GetNativeMethodInfo().GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return GetNativeMethodInfo().GetCustomAttributes(attributeType, inherit); }
        //public override IList<CustomAttributeData> GetCustomAttributesData() { return method_info.GetCustomAttributesData(); }
        public override bool IsDefined(Type attributeType, bool inherit) { return GetNativeMethodInfo().IsDefined(attributeType, inherit); }
    }
}