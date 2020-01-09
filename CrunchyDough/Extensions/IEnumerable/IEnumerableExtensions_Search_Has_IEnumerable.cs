using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_Has_IEnumerable
    {
        static public bool HasAny<T>(this IEnumerable<T> item, IEnumerable<T> to_check)
        {
            return item.PrepareForMultipass().HasAny<T>(to_check);
        }

        static public bool HasNone<T>(this IEnumerable<T> item, IEnumerable<T> to_check)
        {
            return item.PrepareForMultipass().HasNone(to_check);
        }

        static public bool HasAll<T>(this IEnumerable<T> item, IEnumerable<T> to_check)
        {
            return item.PrepareForMultipass().HasAll(to_check);
        }
    }
}