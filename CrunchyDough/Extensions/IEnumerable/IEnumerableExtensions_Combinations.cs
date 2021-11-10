using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
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

        static public IEnumerable<Tuple<T, T>> TupleCombinations<T>(this IEnumerable<T> item, IEnumerable<T> other)
        {
            other = other.PrepareForMultipass();

            foreach(T sub_item in item)
            {
                foreach (T sub_other in other)
                    yield return Tuple.New(sub_item, sub_other);
            }
        }
        static public IEnumerable<Tuple<T, T, T>> TupleCombinations<T>(this IEnumerable<T> item, IEnumerable<T> other1, IEnumerable<T> other2)
        {
            other1 = other1.PrepareForMultipass();
            other2 = other2.PrepareForMultipass();

            foreach (T sub_item in item)
            {
                foreach (T sub_other1 in other1)
                {
                    foreach(T sub_other2 in other2)
                        yield return Tuple.New(sub_item, sub_other1, sub_other2);
                }
            }
        }
        static public IEnumerable<Tuple<T, T, T, T>> TupleCombinations<T>(this IEnumerable<T> item, IEnumerable<T> other1, IEnumerable<T> other2, IEnumerable<T> other3)
        {
            other1 = other1.PrepareForMultipass();
            other2 = other2.PrepareForMultipass();
            other3 = other3.PrepareForMultipass();

            foreach (T sub_item in item)
            {
                foreach (T sub_other1 in other1)
                {
                    foreach (T sub_other2 in other2)
                    {
                        foreach (T sub_other3 in other3)
                            yield return Tuple.New(sub_item, sub_other1, sub_other2, sub_other3);
                    }
                }
            }
        }
    }
}