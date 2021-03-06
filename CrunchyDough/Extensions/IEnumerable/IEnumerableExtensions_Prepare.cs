using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Prepare
    {
        static public ICollection<T> PrepareForMultipass<T>(this IEnumerable<T> item)
        {
            if (item is ICollection<T>)
                return (ICollection<T>)item;

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