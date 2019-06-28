using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Prepare
    {
        static public IEnumerable<T> PrepareForMultipass<T>(this IEnumerable<T> item)
        {
            if (item is ICollection<T>)
                return item;

            if (item is ICollection)
                return item;

            return item.ToList();
        }

        static public IList<T> PrepareForIndexing<T>(this IEnumerable<T> item)
        {
            if (item is IList<T>)
                return (IList<T>)item;

            return item.ToList();
        }
    }
}