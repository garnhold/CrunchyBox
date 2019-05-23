using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class ConstructorInfoPass : ConstructorInfo, ForeignConstructorInfo
    {
        public abstract ConstructorInfo GetNativeConstructorInfo();

        public override string ToString()
        {
            return DeclaringType.ToString() + "(" + GetParameters().ToString(",") + ")";
        }

        //ConstructorInfo
        public override MemberTypes MemberType { get{ return GetNativeConstructorInfo().MemberType; } }
        public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { return GetNativeConstructorInfo().Invoke(invokeAttr, binder, parameters, culture); }

        //MethodBase
        public override MethodAttributes Attributes { get { return GetNativeConstructorInfo().Attributes; } }
        public override CallingConventions CallingConvention { get { return GetNativeConstructorInfo().CallingConvention; } }
        public override bool ContainsGenericParameters { get { return GetNativeConstructorInfo().ContainsGenericParameters; } }
        public override bool IsGenericMethod { get { return GetNativeConstructorInfo().IsGenericMethod; } }
        public override bool IsGenericMethodDefinition { get { return GetNativeConstructorInfo().IsGenericMethodDefinition; } }
        public override RuntimeMethodHandle MethodHandle { get { return GetNativeConstructorInfo().MethodHandle; } }
        public override Type[] GetGenericArguments() { return GetNativeConstructorInfo().GetGenericArguments(); }
        public override MethodBody GetMethodBody() { return GetNativeConstructorInfo().GetMethodBody(); }
        public override MethodImplAttributes GetMethodImplementationFlags() { return GetNativeConstructorInfo().GetMethodImplementationFlags(); }
        public override ParameterInfo[] GetParameters() { return GetNativeConstructorInfo().GetParameters(); }
        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { return GetNativeConstructorInfo().Invoke(obj, invokeAttr, binder, parameters, culture); }

        //MemberInfo
        public override Type DeclaringType { get { return GetNativeConstructorInfo().DeclaringType; } }
        public override int MetadataToken { get { return GetNativeConstructorInfo().MetadataToken; } }
        public override Module Module { get { return GetNativeConstructorInfo().Module; } }
        public override string Name { get { return GetNativeConstructorInfo().Name; } }
        public override Type ReflectedType { get { return GetNativeConstructorInfo().ReflectedType; } }

        public override object[] GetCustomAttributes(bool inherit) { return GetNativeConstructorInfo().GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return GetNativeConstructorInfo().GetCustomAttributes(attributeType, inherit); }
        public override bool IsDefined(Type attributeType, bool inherit) { return GetNativeConstructorInfo().IsDefined(attributeType, inherit); }
    }
}