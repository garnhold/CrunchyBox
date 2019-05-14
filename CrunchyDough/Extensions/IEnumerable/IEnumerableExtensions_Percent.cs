using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Percent
    {
        static public double Percent<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            int total;

            return (double)item.Count(predicate, out total) / (double)total;
        }

        static public double Percent<T>(this IEnumerable<T> item, T to_count)
        {
            return item.Percent(i => i.EqualsEX(to_count));
        }
    }
}