using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Meld
    {
        static public IEnumerable<T> Meld<T>(this IEnumerable<T> item, Relation<T, T> relation, Operation<T, T, T> operation)
        {
            T current_item;
            T previous_item;

            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                if (iter.MoveNext())
                {
                    previous_item = iter.Current;

                    while (iter.MoveNext())
                    {
                        current_item = iter.Current;

                        if (relation(previous_item, current_item))
                            yield return operation(previous_item, current_item);
                        else
                            yield return current_item;

                        previous_item = current_item;
                    }
                }
            }
        }
    }
}