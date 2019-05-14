using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Extended
    {
        static public bool TryRummage<T>(this IEnumerable<T> item, Predicate<T> predicate, Process<T> process, out T value)
        {
            foreach (T sub_item in item)
            {
                if (predicate.DoesDescribe(sub_item))
                {
                    value = sub_item;
                    return true;
                }

                process(sub_item);
            }

            value = default(T);
            return false;
        }
        static public T Rummage<T>(this IEnumerable<T> item, Predicate<T> predicate, Process<T> process)
        {
            T value;

            item.TryRummage(predicate, process, out value);
            return value;
        }

        static public bool TryExcavate<T>(this IEnumerable<T> item, Predicate<T> predicate, Process<T> process, out T value)
        {
            value = item.FindFirst(predicate);
            item.EndBefore(value).Process(process);
            return false;
        }
        static public T Excavate<T>(this IEnumerable<T> item, Predicate<T> predicate, Process<T> process)
        {
            T value;

            item.TryExcavate(predicate, process, out value);
            return value;
        }
    }
}