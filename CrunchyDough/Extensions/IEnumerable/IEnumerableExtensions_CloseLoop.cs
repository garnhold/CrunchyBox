using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_CloseLoop
    {
        static public IEnumerable<T> CloseLoop<T>(this IEnumerable<T> item)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                if (iterator.MoveNext())
                {
                    T first = iterator.Current;

                    yield return first;

                    while (iterator.MoveNext())
                        yield return iterator.Current;

                    yield return first;
                }
            }
        }
    }
}