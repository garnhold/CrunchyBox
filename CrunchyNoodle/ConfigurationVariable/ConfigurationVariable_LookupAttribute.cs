using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class ConfigurationVariable_LookupAttribute : ConfigurationVariableAttribute
    {
        private Type attribute_type;

        protected override bool TryHydrateSettingInternal(string option_string, Type option_type, out object option_value)
        {
            FieldInfo field = Fields.GetFilteredStaticFields(
                Filterer_FieldInfo.CanBeTreatedAs(option_type),
                Filterer_FieldInfo.HasCustomAttributeOfType(attribute_type)
            ).FindFirst(f => f.GetCustomAttributeOfSubType<ConfigurationValueAttribute>(attribute_type, false)
                .CheckOptionString(option_string)
            );

            if(field != null)
            {
                option_value = field.GetValue(null);
                return true;
            }

            option_value = null;
            return false;
        }

        public ConfigurationVariable_LookupAttribute(string n, string d, string v, Type t, params string[] a) : base(n, d, v, a) 
        {
            attribute_type = t;
        }

        public ConfigurationVariable_LookupAttribute(string n, string d, Type t) : this(n, d, "", t) { }
        public ConfigurationVariable_LookupAttribute(string n, Type t) : this(n, "", t) { }
    }
}