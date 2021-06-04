using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Flatten
    {
        static public IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> item)
        {
            if (item != null)
            {
                foreach (IEnumerable<T> sub_item in item)
                {
                    if (sub_item != null)
                    {
                        foreach (T sub_sub_item in sub_item)
                            yield return sub_sub_item;
                    }
                }
            }
        }

        static public IEnumerable<T> Flatten<T>(this IEnumerable<List<T>> item)
        {
            return item.Convert(i => (IEnumerable<T>)i).Flatten();
        }

        static public IEnumerable<T> Flatten<T>(this IEnumerable<HashSet<T>> item)
        {
            return item.Convert(i => (IEnumerable<T>)i).Flatten();
        }
    }
}