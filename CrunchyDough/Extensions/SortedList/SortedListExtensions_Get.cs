using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class SortedListExtensions_Get
    {
        static public VALUE_TYPE Get<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item, int index)
        {
            return item.Values.Get(index);
        }

        static public VALUE_TYPE GetFirst<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item)
        {
            return item.Values.GetFirst();
        }

        static public VALUE_TYPE GetLast<KEY_TYPE, VALUE_TYPE>(this SortedList<KEY_TYPE, VALUE_TYPE> item)
        {
            return item.Values.GetLast();
        }
    }
}