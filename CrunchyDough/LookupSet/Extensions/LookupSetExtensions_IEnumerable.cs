using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LookupSetExtensions_IEnumerable
    {
        static public bool Has<KEY_TYPE, VALUE_TYPE>(this IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> item, KEY_TYPE key)
        {
            foreach (LookupSet<KEY_TYPE, VALUE_TYPE> set in item)
            {
                if (set != null)
                {
                    if (set.Has(key))
                        return true;
                }
            }

            return false;
        }

        static public bool TryLookup<KEY_TYPE, VALUE_TYPE>(this IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> item, KEY_TYPE key, out VALUE_TYPE value)
        {
            foreach (LookupSet<KEY_TYPE, VALUE_TYPE> set in item)
            {
                if (set != null)
                {
                    if (set.TryLookup(key, out value))
                        return true;
                }
            }

            value = default(VALUE_TYPE);
            return false;
        }

        static public VALUE_TYPE Lookup<KEY_TYPE, VALUE_TYPE>(this IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> item, KEY_TYPE key)
        {
            VALUE_TYPE value;

            item.TryLookup(key, out value);
            return value;
        }
    }
}