using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_End
    {
        static public IEnumerable<T> EndAt<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    yield return iterator.Current;

                    if (predicate.DoesDescribe(iterator.Current))
                        yield break;
                }
            }
        }
        static public IEnumerable<T> EndAt<T>(this IEnumerable<T> item, T value)
        {
            return item.EndAt(i => i.EqualsEX(value));
        }

        static public IEnumerable<T> EndBefore<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    if (predicate.DoesDescribe(iterator.Current))
                        yield break;

                    yield return iterator.Current;
                }
            }
        }
        static public IEnumerable<T> EndBefore<T>(this IEnumerable<T> item, T value)
        {
            return item.EndBefore(i => i.EqualsEX(value));
        }

        static public IEnumerable<T> EndAfter<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    yield return iterator.Current;

                    if (predicate.DoesDescribe(iterator.Current))
                    {
                        if (iterator.MoveNext())
                            yield return iterator.Current;

                        yield break;
                    }
                }
            }
        }
        static public IEnumerable<T> EndAfter<T>(this IEnumerable<T> item, T value)
        {
            return item.EndAfter(i => i.EqualsEX(value));
        }
    }
}