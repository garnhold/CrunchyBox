using System;

namespace Crunchy.Dough
{
    static public class LookupSetExtensions_Lookup
    {
        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key)
        {
            VALUE_TYPE value;

            item.TryLookup(key, out value);
            return value;
        }

        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, VALUE_TYPE default_value)
        {
            VALUE_TYPE value;

            if (item.TryLookup(key, out value))
                return value;

            return default_value;
        }
    }
}