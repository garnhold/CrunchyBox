using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Insert_Marker
    {
        static public void InsertBefore<T>(this IList<T> item, T marker, T to_insert)
        {
            item.Insert(item.FindIndexOf(marker), to_insert);
        }
        static public void InsertRangeBefore<T>(this IList<T> item, T marker, IEnumerable<T> to_insert)
        {
            item.InsertRange(item.FindIndexOf(marker), to_insert);
        }

        static public void InsertRangeBefore<T>(this IList<T> item, T marker, IEnumerable<T> to_insert, out T first, out T last)
        {
            item.InsertRange(item.FindIndexOf(marker), to_insert, out first, out last);
        }
        static public T InsertRangeBeforeGetFirst<T>(this IList<T> item, T marker, IEnumerable<T> to_insert)
        {
            return item.InsertRangeGetFirst(item.FindIndexOf(marker), to_insert);
        }
        static public T InsertRangeBeforeGetLast<T>(this IList<T> item, T marker, IEnumerable<T> to_insert)
        {
            return item.InsertRangeGetLast(item.FindIndexOf(marker), to_insert);
        }

        static public void InsertAfter<T>(this IList<T> item, T marker, T to_insert)
        {
            item.Insert(item.FindIndexOf(marker) + 1, to_insert);
        }
        static public void InsertRangeAfter<T>(this IList<T> item, T marker, IEnumerable<T> to_insert)
        {
            item.InsertRange(item.FindIndexOf(marker) + 1, to_insert);
        }

        static public void InsertRangeAfter<T>(this IList<T> item, T marker, IEnumerable<T> to_insert, out T first, out T last)
        {
            item.InsertRange(item.FindIndexOf(marker) + 1, to_insert, out first, out last);
        }
        static public T InsertRangeAfterGetFirst<T>(this IList<T> item, T marker, IEnumerable<T> to_insert)
        {
            return item.InsertRangeGetFirst(item.FindIndexOf(marker) + 1, to_insert);
        }
        static public T InsertRangeAfterGetLast<T>(this IList<T> item, T marker, IEnumerable<T> to_insert)
        {
            return item.InsertRangeGetLast(item.FindIndexOf(marker) + 1, to_insert);
        }
    }
}