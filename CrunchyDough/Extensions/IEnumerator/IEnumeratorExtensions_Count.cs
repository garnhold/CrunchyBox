using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumeratorExtensions_Count
    {
        static public bool TryFindNextCount<T>(this IEnumerator<T> item, out int count, Predicate<T> predicate)
        {
            count = 0;

            while (item.MoveNext())
            {
                count++;

                if (predicate.DoesDescribe(item.Current))
                    return true;
            }

            return false;
        }
        static public bool TryFindNextCount<T>(this IEnumerator<T> item, out int count, T to_check)
        {
            return item.TryFindNextCount(out count, i => i.EqualsEX(to_check));
        }

        static public int ExhaustNextCount<T>(this IEnumerator<T> item)
        {
            int count = 0;

            while (item.MoveNext())
                count++;

            return count;
        }
    }
}