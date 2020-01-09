using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Flatten
    {
        static public IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> item)
        {
            return item.Convert(i => (IEnumerable<T>)i);
        }

        static public IEnumerable<T> Flatten<T>(this IEnumerable<List<T>> item)
        {
            return item.Convert(i => (IEnumerable<T>)i);
        }

        static public IEnumerable<T> Flatten<T>(this IEnumerable<HashSet<T>> item)
        {
            return item.Convert(i => (IEnumerable<T>)i);
        }
    }
}