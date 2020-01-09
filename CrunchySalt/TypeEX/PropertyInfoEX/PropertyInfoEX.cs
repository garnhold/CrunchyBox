using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public class PropertyInfoEX : PropertyInfoPass
    {
        private PropertyInfo native_property_info;

        private BasicPropertySetter basic_property_setter;
        private BasicPropertyGetter basic_property_getter;

        static private OperationCache<PropertyInfoEX, PropertyInfo> GET_PROPERTY_INFO_EX = ReflectionCache.Get().NewOperationCache("GET_PROPERTY_INFO_EX", delegate(PropertyInfo property_info) {
            return new PropertyInfoEX(property_info);
        });
        static public PropertyInfoEX GetPropertyInfoEX(PropertyInfo property_info)
        {
            PropertyInfoEX cast;

            if (property_info != null)
            {
                if (property_info.Convert<PropertyInfoEX>(out cast))
                    return cast;

                return GET_PROPERTY_INFO_EX.Fetch(property_info);
            }

            return null;
        }

        protected PropertyInfoEX(PropertyInfo p)
        {
            native_property_info = p;
        }

        public override PropertyInfo GetNativePropertyInfo()
        {
            return native_property_info;
        }

        public BasicPropertySetter GetBasicPropertySetter()
        {
            if (basic_property_setter == null)
                basic_property_setter = GetNativePropertyInfo().CreateDynamicPropertySetterDelegate<BasicPropertySetter>();

            return basic_property_setter;
        }

        public BasicPropertyGetter GetBasicPropertyGetter()
        {
            if (basic_property_getter == null)
                basic_property_getter = GetNativePropertyInfo().CreateDynamicPropertyGetterDelegate<BasicPropertyGetter>();

            return basic_property_getter;
        }

        public override object GetValue(object obj, object[] index)
        {
            return GetBasicPropertyGetter()(obj, index);
        }
        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            return GetBasicPropertyGetter()(obj, index);
        }

        public override void SetValue(object obj, object value, object[] index)
        {
            GetBasicPropertySetter()(obj, index, value);
        }
        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            GetBasicPropertySetter()(obj, index, value);
        }
    }
}