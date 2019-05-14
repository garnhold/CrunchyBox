using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Combinations
    {
        static public IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<IEnumerable<T>> item)
        {
            IEnumerable<T> sub_items;

            if (item.TryGetFirst(out sub_items))
            {
                using (IEnumerator<IEnumerable<T>> iter = item.Offset(1).Combinations().GetEnumerator())
                {
                    if (iter.MoveNext())
                    {
                        do
                        {
                            foreach (T sub_item in sub_items)
                                yield return iter.Current.Prepend(sub_item);

                        } while (iter.MoveNext());
                    }
                    else
                    {
                        foreach (T sub_item in sub_items)
                            yield return sub_item.WrapAsEnumerable();
                    }
                }
            }
        }
        static public IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> item, IEnumerable<IEnumerable<T>> others)
        {
            return others.Prepend(item).Combinations();
        }
        static public IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> item, params IEnumerable<T>[] others)
        {
            return item.Combinations((IEnumerable<IEnumerable<T>>)others);
        }

        static public IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> item, int number)
        {
            return item.Repeat(number).Combinations();
        }
    }
}