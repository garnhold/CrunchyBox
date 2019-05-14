using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class ConfigurationValue_RegexAttribute : ConfigurationValueAttribute
    {
        private List<string> option_string_patterns;

        public ConfigurationValue_RegexAttribute(params string[] o)
        {
            option_string_patterns = o.ToList();
        }

        public override bool CheckOptionString(string option_string)
        {
            if(option_string_patterns.Has(p => option_string.RegexIsMatch(p)))
                return true;

            return false;
        }
    }
}