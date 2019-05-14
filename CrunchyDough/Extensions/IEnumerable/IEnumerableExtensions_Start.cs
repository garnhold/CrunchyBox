using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Start
    {
        static public IEnumerable<T> StartWhen<T>(this IEnumerable<T> item, Predicate<T> predicate, bool include_first)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    if (predicate.DoesDescribe(iterator.Current))
                    {
                        if (include_first)
                            yield return iterator.Current;

                        while (iterator.MoveNext())
                            yield return iterator.Current;

                        yield break;
                    }
                }
            }
        }

        static public IEnumerable<T> StartAt<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            return item.StartWhen(predicate, true);
        }
        static public IEnumerable<T> StartAt<T>(this IEnumerable<T> item, T value)
        {
            return item.StartAt(i => i.EqualsEX(value));
        }

        static public IEnumerable<T> StartAfter<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            return item.StartWhen(predicate, false);
        }
        static public IEnumerable<T> StartAfter<T>(this IEnumerable<T> item, T value)
        {
            return item.StartAfter(i => i.EqualsEX(value));
        }
    }
}