using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class HashSetExtensions_Contains
    {
        static public bool ContainsAny<T>(this HashSet<T> item, IEnumerable<T> to_check)
        {
            foreach (T sub_to_check in to_check)
            {
                if (item.Contains(sub_to_check))
                    return true;
            }

            return false;
        }
    }
}