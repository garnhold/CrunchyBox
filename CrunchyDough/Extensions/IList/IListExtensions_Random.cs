using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
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
        static public T PickRandom<T>(this IList<T> item, Operation<double, T> operation)
        {
            return item.PickRandom(operation, RandFloat.SOURCE);
        }

        static public IEnumerable<T> RotateRandom<T>(this IList<T> item, RandIntSource source)
        {
            return item.RotateLooped(source.Get());
        }
        static public IEnumerable<T> RotateRandom<T>(this IList<T> item)
        {
            return item.RotateRandom(RandInt.SOURCE);
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

        static public void RemoveBeginningRandom<T>(this IList<T> item, RandIntSource source)
        {
            item.RemoveBeginning(source.GetIndex(item.Count));
        }
        static public void RemoveBeginningRandom<T>(this IList<T> item)
        {
            item.RemoveBeginningRandom(RandInt.SOURCE);
        }

        static public void RemoveEndingRandom<T>(this IList<T> item, RandIntSource source)
        {
            item.RemoveEnding(source.GetIndex(item.Count));
        }
        static public void RemoveEndingRandom<T>(this IList<T> item)
        {
            item.RemoveEndingRandom(RandInt.SOURCE);
        }
    }
}