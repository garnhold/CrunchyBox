using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Force
    {
        static public ICollection<T> ForceCollection<T>(this IEnumerable<T> item)
        {
            ICollection<T> cast;

            if (item.Convert<ICollection<T>>(out cast))
                return cast;

            return item.ToList();
        }

        static public IList<T> ForceList<T>(this IEnumerable<T> item)
        {
            IList<T> cast;

            if (item.Convert<IList<T>>(out cast))
                return cast;

            return item.ToList();
        }

        static public HashSet<T> ForceHashSet<T>(this IEnumerable<T> item)
        {
            HashSet<T> cast;

            if (item.Convert<HashSet<T>>(out cast))
                return cast;

            return item.ToHashSet();
        }
    }
}