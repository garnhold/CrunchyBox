using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_Find
    {
        static public bool TryFindFirst<T>(this IEnumerable<T> item, Predicate<T> predicate, out T value)
        {
            return item.Narrow(predicate).TryGetFirst(out value);
        }
        static public T FindFirst<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            T value;

            item.TryFindFirst(predicate, out value);
            return value;
        }

        static public bool TryFindOnly<T>(this IEnumerable<T> item, Predicate<T> predicate, out T value)
        {
            return item.Narrow(predicate).TryGetOnly(out value);
        }
        static public T FindOnly<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            T value;

            item.TryFindOnly(predicate, out value);
            return value;
        }
    }
}