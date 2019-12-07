using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Insert
    {
        static public T InsertAndGet<T>(this IList<T> item, int index, T to_insert)
        {
            item.Insert(index, to_insert);
            return to_insert;
        }

        static public void InsertRange<T>(this IList<T> item, int index, IEnumerable<T> to_insert)
        {
            to_insert.ProcessWithIndex((i, z) => item.Insert(index + i, z));
        }

        static public void InsertRange<T>(this IList<T> item, int index, IEnumerable<T> to_insert, out T first, out T last)
        {
            T first_temp = default(T);
            T last_temp = default(T);

            to_insert.ProcessWithIndex(
                (i, z) => first_temp = item.InsertAndGet(index + i, z),
                (i, z) => last_temp = item.InsertAndGet(index + i, z)
            );
            first = first_temp;
            last = last_temp;
        }
        static public T InsertRangeGetFirst<T>(this IList<T> item, int index, IEnumerable<T> to_insert)
        {
            T first;
            T last;

            item.InsertRange(index, to_insert, out first, out last);
            return first;
        }
        static public T InsertRangeGetLast<T>(this IList<T> item, int index, IEnumerable<T> to_insert)
        {
            T first;
            T last;

            item.InsertRange(index, to_insert, out first, out last);
            return last;
        }
    }
}