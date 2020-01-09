using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_Add
    {
        static public J AddAndGet<T, J>(this ICollection<T> item, J to_add) where J : T
        {
            item.Add(to_add);

            return to_add;
        }

        static public void AddRange<T>(this ICollection<T> item, IEnumerable<T> to_add)
        {
            to_add.Process(i => item.Add(i));
        }
        static public void AddRange<T>(this ICollection<T> item, params T[] to_add)
        {
            item.AddRange<T>((IEnumerable<T>)to_add);
        }

        static public void AddRange<T>(this ICollection<T> item, IEnumerable<T> to_add, out T first, out T last)
        {
            T first_temp = default(T);
            T last_temp = default(T);

            to_add.Process(i => first_temp = item.AddAndGet(i), i => last_temp = item.AddAndGet(i));
            first = first_temp;
            last = last_temp;
        }
        static public T AddRangeGetFirst<T>(this ICollection<T> item, IEnumerable<T> to_add)
        {
            T first;
            T last;

            item.AddRange(to_add, out first, out last);
            return first;
        }
        static public T AddRangeGetLast<T>(this ICollection<T> item, IEnumerable<T> to_add)
        {
            T first;
            T last;

            item.AddRange(to_add, out first, out last);
            return last;
        }

        static public void AddRepeated<T>(this ICollection<T> item, Operation<T> operation, int times)
        {
            item.AddRange(operation.ExecuteRepeated(times));
        }

        static public void AddRepeated<T>(this ICollection<T> item, T to_add, int times)
        {
            item.AddRange(to_add.Repeat(times));
        }

        static public void AddEmptys<T>(this ICollection<T> item, int times)
        {
            item.AddRepeated(default(T), times);
        }

        static public void Set<T>(this ICollection<T> item, IEnumerable<T> to_add)
        {
            item.Clear();
            item.AddRange(to_add);
        }
        static public void Set<T>(this ICollection<T> item, params T[] to_add)
        {
            item.Set((IEnumerable<T>)to_add);
        }
    }
}