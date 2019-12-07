using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    [AttributeUsage(AttributeTargets.Field)]
    public abstract class ConfigurationVariableAttribute : Attribute
    {
        private StringOption string_option;

        protected abstract bool TryHydrateSettingInternal(string option_string, Type option_type, out object option_value);

        private ConfigurationVariableAttribute(StringOption s)
        {
            string_option = s;
        }

        public ConfigurationVariableAttribute(string n, string d, string v, params string[] a) : this(new StringOption_Basic_Any(n, d, v, a)) { }

        public bool TryHydrateSetting(LookupSet<string, string> settings, object target, FieldInfo field, bool strict = false)
        {
            return string_option.TryUseOptionString(settings, delegate(string option_string) {
                object option_value;

                if (TryHydrateSettingInternal(option_string, field.FieldType, out option_value))
                {
                    field.SetValue(target, option_value);
                    return true;
                }

                return false;
            }, strict);
        }

        public StringOption GetStringOption()
        {
            return string_option;
        }
    }
}