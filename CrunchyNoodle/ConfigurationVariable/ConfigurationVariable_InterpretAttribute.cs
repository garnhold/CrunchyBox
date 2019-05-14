using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class ConfigurationVariable_InterpretAttribute : ConfigurationVariableAttribute
    {
        protected override bool TryHydrateSettingInternal(string option_string, Type option_type, out object option_value)
        {
            return option_string.ConvertEX(option_type, out option_value);
        }

        public ConfigurationVariable_InterpretAttribute(string n, string d, string v, params string[] a) : base(n, d, v, a) { }
        public ConfigurationVariable_InterpretAttribute(string n, string d) : this(n, d, "") { }
        public ConfigurationVariable_InterpretAttribute(string n) : this(n, "") { }
    }
}