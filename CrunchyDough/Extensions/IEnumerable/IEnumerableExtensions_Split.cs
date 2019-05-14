using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Split
    {
        static public IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            if (item != null)
            {
                List<T> chunk = new List<T>();

                foreach (T sub_item in item)
                {
                    if (predicate.DoesDescribe(sub_item))
                    {
                        yield return chunk;
                        chunk = new List<T>();
                    }

                    chunk.Add(sub_item);
                }

                yield return chunk;
            }
        }
    }
}