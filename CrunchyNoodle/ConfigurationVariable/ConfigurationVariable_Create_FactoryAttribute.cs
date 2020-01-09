using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class ConfigurationVariable_Create_FactoryAttribute : ConfigurationVariable_CreateAttribute
    {
        protected override bool TryHydrateSettingInternal(string option_string, Type option_type, out object option_value)
        {
            Type inner_type;

            if (option_type.TryGetGenericArgument(0, out inner_type))
            {
                Type type = GetOptionValueType(option_string, inner_type);

                if (type != null)
                {
                    option_value = option_type.CreateInstance(type);
                    return true;
                }
            }

            option_value = null;
            return false;
        }

        public ConfigurationVariable_Create_FactoryAttribute(string n, string d, string v, Type t, params string[] a) : base(n, d, v, t, a)
        {
        }

        public ConfigurationVariable_Create_FactoryAttribute(string n, string d, Type t) : this(n, d, "", t) { }
        public ConfigurationVariable_Create_FactoryAttribute(string n, Type t) : this(n, "", t) { }
    }
}