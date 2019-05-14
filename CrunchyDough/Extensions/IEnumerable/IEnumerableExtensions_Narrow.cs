using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Narrow
    {
        static public IEnumerable<T> Narrow<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            if (item != null)
            {
                foreach (T sub_item in item)
                {
                    if (predicate.DoesDescribe(sub_item))
                        yield return sub_item;
                }
            }
        }

        static public IEnumerable<T> Narrow<T>(this IEnumerable<T> item, T value)
        {
            return item.Narrow(i => i.EqualsEX(value));
        }

        static public IEnumerable<T> Narrow<T>(this IEnumerable<T> item, IEnumerable<T> values)
        {
            return item.Narrow(i => values.Has(i));
        }

        static public IEnumerable<Tuple<PRIMARY_TYPE, SECONDARY_TYPE>> TryNarrow<PRIMARY_TYPE, SECONDARY_TYPE>(this IEnumerable<PRIMARY_TYPE> item, TryOperation<SECONDARY_TYPE, PRIMARY_TYPE> operation)
        {
            if (item != null)
            {
                foreach (PRIMARY_TYPE sub_item in item)
                {
                    SECONDARY_TYPE secondary_item;

                    if(operation(sub_item, out secondary_item))
                        yield return Tuple.New(sub_item, secondary_item);
                }
            }
        }
    }
}