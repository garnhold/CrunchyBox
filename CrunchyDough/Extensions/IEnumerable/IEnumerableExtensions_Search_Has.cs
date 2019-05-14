using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Has
    {
        static public bool Has<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            foreach (T sub_item in item)
            {
                if (predicate.DoesDescribe(sub_item))
                    return true;
            }

            return false;
        }
        static public bool Has<T>(this IEnumerable<T> item, T to_check)
        {
            return item.Has(it => it.EqualsEX(to_check));
        }

        static public bool HasType<T>(this IEnumerable<T> item, Type type)
        {
            return item.Has(i => i.CanObjectBeTreatedAs(type));
        }
    }
}