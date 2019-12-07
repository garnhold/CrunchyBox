using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Loop
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

        static public IEnumerable<T> OpenLoop<T>(this IEnumerable<T> item)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                if (iterator.MoveNext())
                {
                    T first;

                    T previous;
                    T current;

                    first = iterator.Current;
                    current = first;
                    yield return first;

                    previous = first;

                    if (iterator.MoveNext())
                    {
                        current = iterator.Current;
                        previous = current;

                        while (iterator.MoveNext())
                        {
                            yield return previous;

                            current = iterator.Current;
                            previous = current;
                        }
                    }

                    if (current.NotEqualsEX(first))
                        yield return current;
                }
            }
        }
    }
}