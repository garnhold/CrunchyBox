using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LookupBackedSetExtensions_Compare
    {
        static public bool IsAsBacked<KEY_TYPE, VALUE_TYPE>(this LookupBackedSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key)
        {
            return item.Is(key, item.GetFallbackSets().Lookup(key));
        }
    }
}