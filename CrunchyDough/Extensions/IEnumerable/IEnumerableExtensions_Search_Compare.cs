using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Compare
    {
        static public T FindLowest<T>(this IEnumerable<T> item) where T : IComparable<T>
        {
            return item.FindRolling((i1, i2) => i1.Min(i2));
        }

        static public T FindHighest<T>(this IEnumerable<T> item) where T : IComparable<T>
        {
            return item.FindRolling((i1, i2) => i1.Max(i2));
        }
    }
}