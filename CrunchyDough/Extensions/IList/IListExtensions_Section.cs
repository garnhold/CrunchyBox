using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Section
    {
        static public IListSubSection<T> SubSection<T>(this IList<T> item, int start, int end)
        {
            return new IListSubSection<T>(start, end, item);
        }

        static public IListSubSection<T> Sub<T>(this IList<T> item, int start, int length)
        {
            return item.SubSection(start, start + length);
        }

        static public IListSubSection<T> Offset<T>(this IList<T> item, int start)
        {
            return item.SubSection(start, item.Count);
        }

        static public IListSubSection<T> Truncate<T>(this IList<T> item, int end)
        {
            return item.SubSection(0, end);
        }

        static public IListSubSection<T> Trim<T>(this IList<T> item, int amount)
        {
            return item.Truncate(item.Count - amount);
        }
    }
}