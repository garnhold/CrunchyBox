using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_ConvertConnections
    {
        static public IEnumerable<J> ConvertConnections<T, J>(this IEnumerable<T> item, Operation<J, T, T> operation)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                if (iterator.MoveNext())
                {
                    T previous = iterator.Current;

                    while (iterator.MoveNext())
                    {
                        T current = iterator.Current;

                        yield return operation(previous, current);
                        previous = current;
                    }
                }
            }
        }
        static public IEnumerable<Tuple<T, T>> ConvertConnections<T>(this IEnumerable<T> item)
        {
            return item.ConvertConnections((i1, i2) => Tuple.New(i1, i2));
        }

        static public IEnumerable<J> ConvertConnections<T, J>(this IEnumerable<T> item, Operation<IEnumerable<J>, T, T> operation)
        {
            return item.ConvertConnections<T, IEnumerable<J>>(operation).Flatten();
        }
    }
}