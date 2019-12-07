using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Exchange
    {
        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, Predicate<T> predicate, Operation<T, T> operation)
        {
            foreach (T sub_item in item)
            {
                if (predicate.DoesDescribe(sub_item))
                    yield return operation(sub_item);
                else
                    yield return sub_item;
            }
        }

        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, Predicate<T> predicate, Operation<T> operation)
        {
            return item.Exchange(predicate, i => operation());
        }

        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, Predicate<T> predicate, T value)
        {
            return item.Exchange(predicate, () => value);
        }

        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, T to_replace, T replacement)
        {
            return item.Exchange(i => i.EqualsEX(to_replace), replacement);
        }

        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, Predicate<T> predicate, Operation<IEnumerable<T>, T> operation)
        {
            foreach (T sub_item in item)
            {
                if (predicate.DoesDescribe(sub_item))
                {
                    foreach (T sub_sub_item in operation(sub_item))
                        yield return sub_sub_item;
                }
                else
                {
                    yield return sub_item;
                }
            }
        }

        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, Predicate<T> predicate, Operation<IEnumerable<T>> operation)
        {
            return item.Exchange(predicate, i => operation());
        }

        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, Predicate<T> predicate, IEnumerable<T> value)
        {
            return item.Exchange(predicate, () => value);
        }

        static public IEnumerable<T> Exchange<T>(this IEnumerable<T> item, T to_replace, IEnumerable<T> replacement)
        {
            return item.Exchange(i => i.EqualsEX(to_replace), replacement);
        }
    }
}