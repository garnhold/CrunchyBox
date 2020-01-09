using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LookupBackedSetExtensions_Create
    {
        static public LookupBackedSet<KEY_TYPE, VALUE_TYPE> AppendFallbacks<KEY_TYPE, VALUE_TYPE>(this LookupBackedSet<KEY_TYPE, VALUE_TYPE> item, IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> fallbacks)
        {
            return new BackedSet<KEY_TYPE, VALUE_TYPE>(item.GetMainSet(), item.GetFallbackSets().Append(fallbacks));
        }
        static public LookupBackedSet<KEY_TYPE, VALUE_TYPE> AppendFallbacks<KEY_TYPE, VALUE_TYPE>(this LookupBackedSet<KEY_TYPE, VALUE_TYPE> item, params LookupSet<KEY_TYPE, VALUE_TYPE>[] fallbacks)
        {
            return item.AppendFallbacks<KEY_TYPE, VALUE_TYPE>((IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>>)fallbacks);
        }

        static public LookupBackedSet<KEY_TYPE, VALUE_TYPE> PrependFallbacks<KEY_TYPE, VALUE_TYPE>(this LookupBackedSet<KEY_TYPE, VALUE_TYPE> item, IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> fallbacks)
        {
            return new BackedSet<KEY_TYPE, VALUE_TYPE>(item.GetMainSet(), item.GetFallbackSets().Prepend(fallbacks));
        }
        static public LookupBackedSet<KEY_TYPE, VALUE_TYPE> PrependFallbacks<KEY_TYPE, VALUE_TYPE>(this LookupBackedSet<KEY_TYPE, VALUE_TYPE> item, params LookupSet<KEY_TYPE, VALUE_TYPE>[] fallbacks)
        {
            return item.PrependFallbacks<KEY_TYPE, VALUE_TYPE>((IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>>)fallbacks);
        }
    }
}