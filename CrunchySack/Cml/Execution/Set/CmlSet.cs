using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSet
    {
        private Dictionary<string, CmlValue> values;

        public CmlSet()
        {
            values = new Dictionary<string, CmlValue>();
        }

        public void SetValue(string name, CmlValue value)
        {
            values[name] = value;
        }

        public CmlValue GetValue(string name)
        {
            return values.GetValue(name);
        }
    }
}
