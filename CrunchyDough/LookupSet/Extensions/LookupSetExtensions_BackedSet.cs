using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LookupSetExtensions_BackedSet
    {
        static public LookupBackedSet<KEY_TYPE, VALUE_TYPE> CreateBackedSet<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> fallbacks)
        {
            return new BackedSet<KEY_TYPE, VALUE_TYPE>(item, fallbacks);
        }
        static public LookupBackedSet<KEY_TYPE, VALUE_TYPE> CreateBackedSet<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, params LookupSet<KEY_TYPE, VALUE_TYPE>[] fallbacks)
        {
            return item.CreateBackedSet<KEY_TYPE, VALUE_TYPE>((IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>>)fallbacks);
        }
    }
}