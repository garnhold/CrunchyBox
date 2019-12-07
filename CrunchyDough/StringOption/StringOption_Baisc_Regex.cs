using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class StringOption_Basic_RegexIsMatch : StringOption_Basic
    {
        private string pattern;

        protected override bool ValidateOptionString(string option_string)
        {
            if(option_string.RegexIsMatch(pattern))
                return true;

            return false;
        }

        public StringOption_Basic_RegexIsMatch(string n, string p, string d, string v, IEnumerable<string> a) : base(n, d, v, a)
        {
            pattern = p;
        }

        public StringOption_Basic_RegexIsMatch(string n, string p, string d, string v, params string[] a) : this(n, d, v, p, (IEnumerable<string>)a) { }
        public StringOption_Basic_RegexIsMatch(string n, string p, string d) : this(n, p, d, "") { }
        public StringOption_Basic_RegexIsMatch(string n, string p) : this(n, p, "") { }
    }
}