using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Index
    {
        static public bool TryFindIndexOf<T>(this IEnumerable<T> item, out int index, Predicate<T> predicate)
        {
            index = 0;

            foreach (T sub_item in item)
            {
                if (predicate.DoesDescribe(sub_item))
                    return true;

                index++;
            }

            return false;
        }
        static public bool TryFindIndexOf<T>(this IEnumerable<T> item, out int index, T to_check)
        {
            return item.TryFindIndexOf(out index, i => i.EqualsEX(to_check));
        }

        static public int FindIndexOf<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            int index;

            item.TryFindIndexOf(out index, predicate);
            return index;
        }
        static public int FindIndexOf<T>(this IEnumerable<T> item, T to_check)
        {
            return item.FindIndexOf(i => i.EqualsEX(to_check));
        }

        static public IndexSituation DetermineIndexSituation<T>(this IEnumerable<T> item, T to_check)
        {
            int index = -1;
            int count = 0;

            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                if (iter.TryFindNextCount(out count, to_check))
                    index = count - 1;

                count += iter.ExhaustNextCount();
            }

            return new IndexSituation(index, count);
        }
    }
}