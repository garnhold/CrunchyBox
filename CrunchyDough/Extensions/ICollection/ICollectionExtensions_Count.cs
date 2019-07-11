using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_Count
    {
        static public int Count<T>(this ICollection<T> item)
        {
            if (item != null)
                return item.Count;

            return 0;
        }

        static public bool IsNotEmpty<T>(this ICollection<T> item)
        {
            if (item.Count() > 0)
                return true;

            return false;
        }

        static public bool IsEmpty<T>(this ICollection<T> item)
        {
            if (item.IsNotEmpty() == false)
                return true;

            return false;
        }

        static public bool HasOnlyOne<T>(this ICollection<T> item)
        {
            if (item.Count() == 1)
                return true;

            return false;
        }
    }
}