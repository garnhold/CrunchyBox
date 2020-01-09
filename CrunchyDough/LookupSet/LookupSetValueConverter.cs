using System;

namespace Crunchy.Dough
{
    public class LookupSetValueConverter<KEY_TYPE, INPUT_TYPE, OUTPUT_TYPE> : LookupSet<KEY_TYPE, OUTPUT_TYPE>
    {
        private LookupSet<KEY_TYPE, INPUT_TYPE> set;
        private Operation<OUTPUT_TYPE, INPUT_TYPE> operation;

        public LookupSetValueConverter(LookupSet<KEY_TYPE, INPUT_TYPE> s, Operation<OUTPUT_TYPE, INPUT_TYPE> o)
        {
            set = s;
            operation = o;
        }

        public bool Has(KEY_TYPE key)
        {
            return set.Has(key);
        }

        public bool TryLookup(KEY_TYPE key, out OUTPUT_TYPE value)
        {
            INPUT_TYPE intermediate_value;

            if (set.TryLookup(key, out intermediate_value))
            {
                value = operation.Execute(intermediate_value);
                return true;
            }

            value = default(OUTPUT_TYPE);
            return false;
        }
    }
}