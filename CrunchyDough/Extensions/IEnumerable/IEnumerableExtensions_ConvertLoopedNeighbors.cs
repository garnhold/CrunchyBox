using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_ConvertLoopedNeighbors
    {
        static public IEnumerable<J> ConvertLoopedNeighbors<T, J>(this IEnumerable<T> item, Operation<J, T, T, T> operation)
        {
            IList<T> list = item.PrepareForIndexing();

            for (int i = 0; i < list.Count; i++)
            {
                yield return operation(
                    list.GetLooped(i - 1),
                    list.GetLooped(i),
                    list.GetLooped(i + 1)
                );
            }
        }
    }
}