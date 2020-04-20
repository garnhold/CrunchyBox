using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Section
    {
        static public IList<T> SubSection<T>(this IList<T> item, int start, int end)
        {
            start = start.BindBetween(0, item.Count);
            end = end.BindBetween(start, item.Count);

            return new IListTransform<T>(
                end - start,
                i => item[start + i],
                (i, v) => item[start + i] = v
            );
        }

        static public IList<T> SubArea<T>(this IList<T> item, int center, int radius)
        {
            return item.SubSection<T>(center - radius, center + radius);
        }

        static public IList<T> Sub<T>(this IList<T> item, int start, int length)
        {
            return item.SubSection(start, start + length);
        }

        static public IList<T> Offset<T>(this IList<T> item, int start)
        {
            return item.SubSection(start, item.Count);
        }
        static public IList<T> OffsetFromEnd<T>(this IList<T> item, int amount)
        {
            return item.Offset(item.Count - amount);
        }

        static public IList<T> Truncate<T>(this IList<T> item, int end)
        {
            return item.SubSection(0, end);
        }
        static public IList<T> TruncateFromEnd<T>(this IList<T> item, int amount)
        {
            return item.Truncate(item.Count - amount);
        }
    }
}