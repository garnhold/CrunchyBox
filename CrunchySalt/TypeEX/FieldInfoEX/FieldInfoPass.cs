using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class FieldInfoPass : FieldInfo, ForeignFieldInfo
    {
        public abstract FieldInfo GetNativeFieldInfo();

        public override string ToString()
        {
            return FieldType.ToString() + " " + Name;
        }

        //FieldInfo
        public override FieldAttributes Attributes { get {return GetNativeFieldInfo().Attributes; } }
        public override RuntimeFieldHandle FieldHandle { get { return GetNativeFieldInfo().FieldHandle; } }
        public override Type FieldType { get { return GetNativeFieldInfo().FieldType; } }
        //public override bool IsSecurityCritical { get { return field_info.IsSecurityCritical; } }
        //public override bool IsSecuritySafeCritical { get { return field_info.IsSecuritySafeCritical; } }
        //public override bool IsSecurityTransparent { get { return field_info.IsSecurityTransparent; } }
        public override MemberTypes MemberType { get { return GetNativeFieldInfo().MemberType; } }

        public override Type[] GetOptionalCustomModifiers() { return GetNativeFieldInfo().GetOptionalCustomModifiers(); }
        public override object GetRawConstantValue() { return GetNativeFieldInfo().GetRawConstantValue(); }
        public override Type[] GetRequiredCustomModifiers() { return GetNativeFieldInfo().GetRequiredCustomModifiers(); }
        
        public override object GetValueDirect(TypedReference obj) { return GetNativeFieldInfo().GetValueDirect(obj); }
        public override void SetValueDirect(TypedReference obj, object value) { GetNativeFieldInfo().SetValueDirect(obj, value); }

        public override object GetValue(object obj) { return GetNativeFieldInfo().GetValue(obj); }
        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { GetNativeFieldInfo().SetValue(obj, value, invokeAttr, binder, culture); }

        //MemberInfo
        //public override IEnumerable<CustomAttributeData> CustomAttributes { get { return field_info.CustomAttributes; } }
        public override Type DeclaringType { get { return GetNativeFieldInfo().DeclaringType; } }
        public override int MetadataToken { get { return GetNativeFieldInfo().MetadataToken; } }
        public override Module Module { get { return GetNativeFieldInfo().Module; } }
        public override string Name { get { return GetNativeFieldInfo().Name; } }
        public override Type ReflectedType { get { return GetNativeFieldInfo().ReflectedType; } }
        public override object[] GetCustomAttributes(bool inherit) { return GetNativeFieldInfo().GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return GetNativeFieldInfo().GetCustomAttributes(attributeType, inherit); }
        //public override IList<CustomAttributeData> GetCustomAttributesData() { return field_info.GetCustomAttributesData(); }
        public override bool IsDefined(Type attributeType, bool inherit) { return GetNativeFieldInfo().IsDefined(attributeType, inherit); }
    }
}