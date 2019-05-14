using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class LookupSetExtensions_NarrowSet
    {
        static public LookupSet<KEY_TYPE, VALUE_TYPE> NarrowSet<KEY_TYPE, VALUE_TYPE>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, Predicate<VALUE_TYPE> predicate)
        {
            return new LookupSetValueNarrower<KEY_TYPE, VALUE_TYPE>(item, predicate);
        }
    }
}