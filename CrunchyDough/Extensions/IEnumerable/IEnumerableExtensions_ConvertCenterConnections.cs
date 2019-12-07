using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ConvertCenterConnections
    {
        static public IEnumerable<J> ConvertCenterConnections<T, J>(this IEnumerable<T> item, Operation<J, T, T, T> operation)
        {
            using (IEnumerator<T> iterator = item.GetEnumerator())
            {
                if (iterator.MoveNext())
                {
                    T left = iterator.Current;

                    if (iterator.MoveNext())
                    {
                        T center = iterator.Current;

                        while (iterator.MoveNext())
                        {
                            T right = iterator.Current;

                            yield return operation(left, center, right);

                            left = center;
                            center = right;
                        }
                    }
                }
            }
        }

        static public IEnumerable<Tuple<T, T, T>> ConvertCenterConnections<T>(this IEnumerable<T> item)
        {
            return item.ConvertCenterConnections((i1, i2, i3) => Tuple.New(i1, i2, i3));
        }

        static public IEnumerable<J> ConvertCenterConnections<T, J>(this IEnumerable<T> item, Operation<IEnumerable<J>, T, T, T> operation)
        {
            return item.ConvertCenterConnections<T, IEnumerable<J>>(operation).Flatten();
        }
    }
}