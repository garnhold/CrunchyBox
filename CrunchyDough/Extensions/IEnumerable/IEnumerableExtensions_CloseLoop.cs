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
                    T first;
                    T current;

                    first = iterator.Current;
                    current = first;
                    yield return first;

                    while (iterator.MoveNext())
                    {
                        current = iterator.Current;
                        yield return current;
                    }

                    if (current.NotEqualsEX(first))
                        yield return first;
                }
            }
        }
    }
}