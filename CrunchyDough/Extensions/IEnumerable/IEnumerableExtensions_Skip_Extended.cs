using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Skip_Extended
    {
        static public IEnumerable<T> SkipDuplicates<T>(this IEnumerable<T> item)
        {
            if (item != null)
            {
                HashSet<T> returned = new HashSet<T>();

                foreach (T sub_item in item)
                {
                    if (returned.Add(sub_item))
                        yield return sub_item;
                }
            }
        }

        static public IEnumerable<T> SkipNonUnique<T>(this IEnumerable<T> item)
        {
            HashSet<T> set = new HashSet<T>();

            foreach (T sub_item in item)
            {
                if (set.Add(sub_item) == false)
                    set.Remove(sub_item);
            }

            return set;
        }
    }
}