using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class LookupSetExtensions_Fallback
    {
        static public bool Has<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> fallbacks)
        {
            if (item != null)
            {
                if (item.Has(key))
                    return true;
            }

            return fallbacks.Has(key);
        }
        static public bool Has<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, params LookupSet<KEY_TYPE, VALUE_TYPE>[] fallbacks)
        {
            return item.Has(key, (IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>>)fallbacks);
        }

        static public bool TryLookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, out VALUE_TYPE value, IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> fallbacks)
        {
            if (item != null)
            {
                if (item.TryLookup(key, out value))
                    return true;
            }

            return fallbacks.TryLookup(key, out value);
        }
        static public bool TryLookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, out VALUE_TYPE value, params LookupSet<KEY_TYPE, VALUE_TYPE>[] fallbacks)
        {
            return item.TryLookup(key, out value, (IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>>)fallbacks);
        }

        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> fallbacks)
        {
            VALUE_TYPE value;

            item.TryLookup(key, out value, fallbacks);
            return value;
        }
        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, params LookupSet<KEY_TYPE, VALUE_TYPE>[] fallbacks)
        {
            return item.Lookup(key, (IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>>)fallbacks);
        }
    }
}