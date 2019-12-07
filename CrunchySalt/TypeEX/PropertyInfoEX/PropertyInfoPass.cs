using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class PropertyInfoPass : PropertyInfo, ForeignPropertyInfo
    {
        public abstract PropertyInfo GetNativePropertyInfo();

        public override string ToString()
        {
            return PropertyType.ToString() + " " + Name;
        }

        public override Type DeclaringType { get { return GetNativePropertyInfo().DeclaringType; } }
        public override MemberTypes MemberType { get { return GetNativePropertyInfo().MemberType; } }
        public override int MetadataToken { get { return GetNativePropertyInfo().MetadataToken; } }
        public override Module Module { get { return GetNativePropertyInfo().Module; } }
        public override string Name { get { return GetNativePropertyInfo().Name; } }
        public override Type ReflectedType { get { return GetNativePropertyInfo().ReflectedType; } }
        public override object[] GetCustomAttributes(bool inherit) { return GetNativePropertyInfo().GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return GetNativePropertyInfo().GetCustomAttributes(attributeType, inherit); }
        public override bool IsDefined(Type attributeType, bool inherit) { return GetNativePropertyInfo().IsDefined(attributeType, inherit); }

        public override PropertyAttributes Attributes { get { return GetNativePropertyInfo().Attributes; } }
        public override bool CanRead { get { return GetNativePropertyInfo().CanRead; } }
        public override bool CanWrite { get { return GetNativePropertyInfo().CanWrite; } }
        public override Type PropertyType { get { return GetNativePropertyInfo().PropertyType; } }
        public override MethodInfo[] GetAccessors(bool nonPublic) { return GetNativePropertyInfo().GetAccessors(nonPublic); }
        public override object GetConstantValue() { return GetNativePropertyInfo().GetConstantValue(); }
        public override MethodInfo GetGetMethod(bool nonPublic) { return GetNativePropertyInfo().GetGetMethod(nonPublic); }
        public override ParameterInfo[] GetIndexParameters() { return GetNativePropertyInfo().GetIndexParameters(); }
        public override Type[] GetOptionalCustomModifiers() { return GetNativePropertyInfo().GetOptionalCustomModifiers(); }
        public override object GetRawConstantValue() { return GetNativePropertyInfo().GetRawConstantValue(); }
        public override Type[] GetRequiredCustomModifiers() { return GetNativePropertyInfo().GetRequiredCustomModifiers(); }
        public override MethodInfo GetSetMethod(bool nonPublic) { return GetNativePropertyInfo().GetSetMethod(nonPublic); }

        public override object GetValue(object obj, object[] index) { return GetNativePropertyInfo().GetValue(obj, index); }
        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { return GetNativePropertyInfo().GetValue(obj, invokeAttr, binder, index, culture); }

        public override void SetValue(object obj, object value, object[] index) { GetNativePropertyInfo().SetValue(obj, value, index); }
        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { GetNativePropertyInfo().SetValue(obj, value, invokeAttr, binder, index, culture); }
    }
}