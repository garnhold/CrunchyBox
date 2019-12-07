using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class ConfigurationVariable_CreateAttribute : ConfigurationVariableAttribute
    {
        private Type attribute_type;

        protected Type GetOptionValueType(string option_string, Type option_type)
        {
            return Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs(option_type),
                Filterer_Type.HasCustomAttributeOfType(attribute_type, false)
            ).FindFirst(t => t.GetCustomAttributeOfType<ConfigurationValueAttribute>(false)
                .CheckOptionString(option_string)
            );
        }

        protected override bool TryHydrateSettingInternal(string option_string, Type option_type, out object option_value)
        {
            Type type = GetOptionValueType(option_string, option_type);

            if (type != null)
            {
                option_value = type.CreateInstance();
                return true;
            }

            option_value = null;
            return false;
        }

        public ConfigurationVariable_CreateAttribute(string n, string d, string v, Type t, params string[] a) : base(n, d, v, a) 
        {
            attribute_type = t;
        }

        public ConfigurationVariable_CreateAttribute(string n, string d, Type t) : this(n, d, "", t) { }
        public ConfigurationVariable_CreateAttribute(string n, Type t) : this(n, "", t) { }
    }
}