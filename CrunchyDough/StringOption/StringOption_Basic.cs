using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class StringOption_Basic : StringOption
    {
        private string name;
        private List<string> alternate_names;

        private string description;
        private string default_value;

        protected abstract bool ValidateOptionString(string option_string);

        protected override bool TryUseOptionStringInternal(LookupSet<string, string> settings, Operation<bool, string> operation)
        {
            string option_value = settings.Lookup(default_value, GetAllNames());

            if (ValidateOptionString(option_value))
            {
                if (operation.Execute(option_value))
                    return true;
            }

            return false;
        }

        public StringOption_Basic(string n, string d, string v, IEnumerable<string> a)
        {
            name = n;
            alternate_names = a.ToList();

            description = d;
            default_value = v;
        }

        public StringOption_Basic(string n, string d, string v, params string[] a) : this(n, d, v, (IEnumerable<string>)a) { }

        public string GetName()
        {
            return name;
        }

        public IEnumerable<string> GetAlternateNames()
        {
            return alternate_names;
        }

        public IEnumerable<string> GetAllNames()
        {
            return alternate_names.Prepend(name);
        }

        public string GetDescription()
        {
            return description;
        }

        public override string ToString()
        {
            return name + "[" + default_value + "]" + "(" + alternate_names.ToString(", ") + "): " + description;
        }
    }
}