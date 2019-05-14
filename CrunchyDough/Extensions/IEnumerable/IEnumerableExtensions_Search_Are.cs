using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Are
    {
        static public bool AreAll<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            foreach (T sub_item in item)
            {
                if (predicate.DoesntDescribe(sub_item))
                    return false;
            }

            return true;
        }
        static public bool AreAll<T>(this IEnumerable<T> item, T to_check)
        {
            return item.AreAll(they => they.EqualsEX(to_check));
        }

        static public bool AreAll<T, J>(this IEnumerable<T> item, Predicate<J> predicate)
        {
            J cast;

            foreach (T sub_item in item)
            {
                if (sub_item.Convert<J>(out cast) && predicate.DoesDescribe(cast))
                    continue;

                return false;
            }

            return true;
        }

        static public bool AreNone<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            foreach (T sub_item in item)
            {
                if (predicate.DoesDescribe(sub_item))
                    return false;
            }

            return true;
        }
        static public bool AreNone<T>(this IEnumerable<T> item, T to_check)
        {
            return item.AreNone(they => they.EqualsEX(to_check));
        }
    }
}