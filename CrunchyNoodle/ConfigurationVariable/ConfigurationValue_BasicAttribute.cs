using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class ConfigurationValue_BasicAttribute : ConfigurationValueAttribute
    {
        private List<string> option_strings;

        public ConfigurationValue_BasicAttribute(params string[] o)
        {
            option_strings = o.ToList();
        }

        public override bool CheckOptionString(string option_string)
        {
            if (option_strings.Has(option_string.StyleAsWord()))
                return true;

            return false;
        }
    }
}