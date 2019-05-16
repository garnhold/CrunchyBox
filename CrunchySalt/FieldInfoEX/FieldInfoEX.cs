using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class FieldInfoEX : FieldInfo, ForeignFieldInfo
    {
        private FieldInfo native_field_info;

        private BasicValueSetter basic_value_setter;
        private BasicValueGetter basic_value_getter;

        static private OperationCache<FieldInfoEX, FieldInfo> GET_FIELD_INFO_EX = ReflectionCache.Get().NewOperationCache(delegate(FieldInfo field_info) {
            return new FieldInfoEX(field_info);
        });
        static public FieldInfoEX GetFieldInfoEX(FieldInfo field_info)
        {
            FieldInfoEX cast;

            if (field_info != null)
            {
                if (field_info.Convert<FieldInfoEX>(out cast))
                    return cast;

                return GET_FIELD_INFO_EX.Fetch(field_info);
            }

            return null;
        }

        protected FieldInfoEX(FieldInfo f)
        {
            native_field_info = f;
        }

        public FieldInfo GetNativeFieldInfo()
        {
            return native_field_info;
        }

        public BasicValueSetter GetBasicValueSetter()
        {
            if (basic_value_setter == null)
                basic_value_setter = native_field_info.CreateDynamicValueSetterDelegate<BasicValueSetter>();

            return basic_value_setter;
        }
        public ValueSetter<T> GetValueSetter<T>()
        {
            return GetBasicValueSetter().GetTypeSafe<T>();
        }

        public BasicValueGetter GetBasicValueGetter()
        {
            if (basic_value_getter == null)
                basic_value_getter = native_field_info.CreateDynamicValueGetterDelegate<BasicValueGetter>();

            return basic_value_getter;
        }
        public ValueGetter<T> GetValueGetter<T>()
        {
            return GetBasicValueGetter().GetTypeSafe<T>();
        }

        public override string ToString()
        {
            return FieldType.ToString() + " " + Name;
        }

        //FieldInfo
        public override FieldAttributes Attributes { get {return native_field_info.Attributes; } }
        public override RuntimeFieldHandle FieldHandle { get { return native_field_info.FieldHandle; } }
        public override Type FieldType { get { return native_field_info.FieldType; } }
        //public override bool IsSecurityCritical { get { return field_info.IsSecurityCritical; } }
        //public override bool IsSecuritySafeCritical { get { return field_info.IsSecuritySafeCritical; } }
        //public override bool IsSecurityTransparent { get { return field_info.IsSecurityTransparent; } }
        public override MemberTypes MemberType { get { return native_field_info.MemberType; } }
        public override bool Equals(object obj) 
        {
            FieldInfo field_info = obj as FieldInfo;

            if (field_info != null)
                return native_field_info.Equals(field_info.GetNativeFieldInfo());

            return false;
        }
        public override int GetHashCode() { return native_field_info.GetHashCode(); }
        public override Type[] GetOptionalCustomModifiers() { return native_field_info.GetOptionalCustomModifiers(); }
        public override object GetRawConstantValue() { return native_field_info.GetRawConstantValue(); }
        public override Type[] GetRequiredCustomModifiers() { return native_field_info.GetRequiredCustomModifiers(); }
        
        public override object GetValueDirect(TypedReference obj) { return native_field_info.GetValueDirect(obj); }
        public override void SetValueDirect(TypedReference obj, object value) { native_field_info.SetValueDirect(obj, value); }

        public override object GetValue(object obj)
        {
            return GetBasicValueGetter()(obj);
        }

        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
        {
            GetBasicValueSetter()(obj, value);
        }

        //MemberInfo
        //public override IEnumerable<CustomAttributeData> CustomAttributes { get { return field_info.CustomAttributes; } }
        public override Type DeclaringType { get { return native_field_info.DeclaringType; } }
        public override int MetadataToken { get { return native_field_info.MetadataToken; } }
        public override Module Module { get { return native_field_info.Module; } }
        public override string Name { get { return native_field_info.Name; } }
        public override Type ReflectedType { get { return native_field_info.ReflectedType; } }
        public override object[] GetCustomAttributes(bool inherit) { return native_field_info.GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return native_field_info.GetCustomAttributes(attributeType, inherit); }
        //public override IList<CustomAttributeData> GetCustomAttributesData() { return field_info.GetCustomAttributesData(); }
        public override bool IsDefined(Type attributeType, bool inherit) { return native_field_info.IsDefined(attributeType, inherit); }
    }
}