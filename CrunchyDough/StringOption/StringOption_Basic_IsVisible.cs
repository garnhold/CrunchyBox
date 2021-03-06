using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class StringOption_Basic_IsVisible : StringOption_Basic
    {
        protected override bool ValidateOptionString(string option_string)
        {
            if (option_string.IsVisible())
                return true;

            return false;
        }

        public StringOption_Basic_IsVisible(string n, string d, string v, IEnumerable<string> a) : base(n, d, v, a) { }
        public StringOption_Basic_IsVisible(string n, string d, string v, params string[] a) : this(n, d, v, (IEnumerable<string>)a) { }
        public StringOption_Basic_IsVisible(string n, string d) : this(n, d, "") { }
    }
}