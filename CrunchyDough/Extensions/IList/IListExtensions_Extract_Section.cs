using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Extract_Section
    {
        static public IEnumerable<T> ExtractSubSection<T>(this IList<T> item, int start, int end)
        {
            List<T> subsection = item.SubSection(start, end).ToList();

            item.RemoveSubSection(start, end);
            return subsection;
        }

        static public IEnumerable<T> ExtractSubArea<T>(this IList<T> item, int center, int radius)
        {
            return item.ExtractSubSection(center - radius, center + radius);
        }

        static public IEnumerable<T> ExtractSub<T>(this IList<T> item, int start, int length)
        {
            return item.ExtractSubSection(start, start + length);
        }

        static public IEnumerable<T> ExtractFront<T>(this IList<T> item, int count)
        {
            return item.ExtractSubSection(0, count);
        }

        static public IEnumerable<T> ExtractBack<T>(this IList<T> item, int count)
        {
            return item.ExtractSubSection(item.Count - count, item.Count);
        }
    }
}