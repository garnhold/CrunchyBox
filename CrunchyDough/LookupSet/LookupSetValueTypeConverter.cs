using System;

namespace CrunchyDough
{
    public class LookupSetValueTypeConverter<KEY_TYPE, INPUT_TYPE, OUTPUT_TYPE> : LookupSet<KEY_TYPE, OUTPUT_TYPE>
    {
        private LookupSet<KEY_TYPE, INPUT_TYPE> set;

        public LookupSetValueTypeConverter(LookupSet<KEY_TYPE, INPUT_TYPE> s)
        {
            set = s;
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
                if(intermediate_value.Convert<OUTPUT_TYPE>(out value))
                    return true;
            }

            value = default(OUTPUT_TYPE);
            return false;
        }
    }
}