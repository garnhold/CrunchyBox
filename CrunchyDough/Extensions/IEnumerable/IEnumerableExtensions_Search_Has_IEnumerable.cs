using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Has_IEnumerable
    {
        static public bool HasAny<T>(this IEnumerable<T> item, IEnumerable<T> to_check)
        {
            return item.ForceCollection().HasAny<T>(to_check);
        }

        static public bool HasNone<T>(this IEnumerable<T> item, IEnumerable<T> to_check)
        {
            return item.ForceCollection().HasNone(to_check);
        }

        static public bool HasAll<T>(this IEnumerable<T> item, IEnumerable<T> to_check)
        {
            return item.ForceCollection().HasAll(to_check);
        }
    }
}