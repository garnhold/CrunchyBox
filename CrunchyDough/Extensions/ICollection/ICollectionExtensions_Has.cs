using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_Has
    {
        static public bool HasAny<T>(this ICollection<T> item, IEnumerable<T> to_check)
        {
            foreach (T sub_item in to_check)
            {
                if (item.Has(sub_item))
                    return true;
            }

            return false;
        }
        static public bool HasNone<T>(this ICollection<T> item, IEnumerable<T> to_check)
        {
            if (item.HasAny(to_check) == false)
                return true;

            return false;
        }

        static public bool HasAll<T>(this ICollection<T> item, IEnumerable<T> to_check)
        {
            foreach (T sub_item in to_check)
            {
                if (item.Has(sub_item) == false)
                    return false;
            }

            return true;
        }
    }
}