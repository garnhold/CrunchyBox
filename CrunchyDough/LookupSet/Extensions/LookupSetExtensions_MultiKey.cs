using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class LookupSetExtensions_MultiKey
    {
        static public bool TryLookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, out VALUE_TYPE value, IEnumerable<KEY_TYPE> keys)
        {
            if (keys != null)
            {
                foreach (KEY_TYPE key in keys)
                {
                    if (item.TryLookup(key, out value))
                        return true;
                }
            }

            value = default(VALUE_TYPE);
            return false;
        }
        static public bool TryLookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, out VALUE_TYPE value, params KEY_TYPE[] keys)
        {
            return item.TryLookup(out value, (IEnumerable<KEY_TYPE>)keys);
        }

        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, IEnumerable<KEY_TYPE> keys)
        {
            VALUE_TYPE value;

            item.TryLookup(out value, keys);
            return value;
        }
        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, params KEY_TYPE[] keys)
        {
            return item.Lookup((IEnumerable<KEY_TYPE>)keys);
        }

        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, VALUE_TYPE default_value, IEnumerable<KEY_TYPE> keys)
        {
            VALUE_TYPE value;

            if (item.TryLookup(out value, keys))
                return value;

            return default_value;
        }
        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, VALUE_TYPE default_value, params KEY_TYPE[] keys)
        {
            return item.Lookup(default_value, (IEnumerable<KEY_TYPE>)keys);
        }
    }
}