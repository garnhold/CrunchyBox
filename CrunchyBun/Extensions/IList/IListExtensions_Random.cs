using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IListExtensions_Random
    {
        static public T GetRandom<T>(this IList<T> item, RandIntSource source)
        {
            return item.Get(source.GetIndex(item.Count));
        }
        static public T GetRandom<T>(this IList<T> item)
        {
            return item.GetRandom(RandInt.SOURCE);
        }

        static public T PopRandom<T>(this IList<T> item, RandIntSource source)
        {
            return item.PopAt(source.GetIndex(item.Count));
        }
        static public T PopRandom<T>(this IList<T> item)
        {
            return item.PopRandom(RandInt.SOURCE);
        }

        static public T PickRandom<T>(this IList<T> item, Operation<double, T> operation, RandFloatSource source)
        {
            double total_cost = item.GetCost(operation);

            return item.GetElementForCost(source.GetBetween(0.0f, (float)total_cost), BoundType.Below, operation);
        }

        static public IEnumerable<T> GetMultipleRandom<T>(this IList<T> item, int count, RandIntSource source)
        {
            for (int i = 0; i < count; i++)
                yield return item.GetRandom(source);
        }
        static public IEnumerable<T> GetMultipleRandom<T>(this IList<T> item, int count)
        {
            return item.GetMultipleRandom(count, RandInt.SOURCE);
        }
    }
}