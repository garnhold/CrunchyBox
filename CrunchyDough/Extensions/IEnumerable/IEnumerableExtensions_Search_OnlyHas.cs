using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_OnlyHas
    {
        static public bool OnlyHas<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            T sub_item;

            if (item.TryGetOnly(out sub_item))
            {
                if (predicate.DoesDescribe(sub_item))
                    return true;
            }

            return false;
        }
        static public bool OnlyHas<T>(this IEnumerable<T> item, T to_check)
        {
            return item.OnlyHas(it => it.EqualsEX(to_check));
        }
    }
}