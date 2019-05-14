using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class PredicateExtensions
    {
        static public bool DoesDescribe<T>(this Predicate<T> item, T to_check)
        {
            return item(to_check);
        }
        static public bool DoesntDescribe<T>(this Predicate<T> item, T to_check)
        {
            if (item.DoesDescribe(to_check) == false)
                return true;

            return false;
        }

        static public bool DoAnyDescribe<T>(this IEnumerable<Predicate<T>> item, T to_check)
        {
            if (item.Has(p => p.DoesDescribe(to_check)))
                return true;

            return false;
        }

        static public bool DoAllDescribe<T>(this IEnumerable<Predicate<T>> item, T to_check)
        {
            if (item.AreAll(p => p.DoesDescribe(to_check)))
                return true;

            return false;
        }
    }
}