using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class FieldInfoEX : FieldInfoPass
    {
        private FieldInfo native_field_info;

        private BasicValueSetter basic_value_setter;
        private BasicValueGetter basic_value_getter;

        static private OperationCache<FieldInfoEX, FieldInfo> GET_FIELD_INFO_EX = ReflectionCache.Get().NewOperationCache("GET_FIELD_INFO_EX", delegate(FieldInfo field_info) {
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

        public override FieldInfo GetNativeFieldInfo()
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

        public override object GetValue(object obj)
        {
            return GetBasicValueGetter()(obj);
        }

        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
        {
            GetBasicValueSetter()(obj, value);
        }
    }
}