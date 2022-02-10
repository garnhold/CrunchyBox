using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class IEnumerableExtensions_Random
    {
        static public IEnumerable<T> Randomize<T>(this IEnumerable<T> item, RandIntSource source)
        {
            List<T> list = item.ToList();

            list.Shuffle(source);
            return list;
        }
        static public IEnumerable<T> Randomize<T>(this IEnumerable<T> item)
        {
            return item.Randomize(RandInt.SOURCE);
        }

        static public IEnumerable<T> RandomizeNearSwaps<T>(this IEnumerable<T> item, int number_swaps, int swap_radius, RandIntSource source)
        {
            List<T> list = item.ToList();

            for (int i = 0; i < number_swaps; i++)
            {
                int index1 = source.GetIndex(list.Count);
                int index2 = (index1 + source.GetOffset(swap_radius)).BindIndex(list.Count);

                list.SwapValues(index1, index2);
            }

            return list;
        }
        static public IEnumerable<T> RandomizeNearSwaps<T>(this IEnumerable<T> item, int number_swaps, int swap_radius)
        {
            return item.RandomizeNearSwaps(number_swaps, swap_radius, RandInt.SOURCE);
        }

        static public IEnumerable<T> RandomizeSwaps<T>(this IEnumerable<T> item, int number_swaps, RandIntSource source)
        {
            List<T> list = item.ToList();

            for (int i = 0; i < number_swaps; i++)
            {
                int index1 = source.GetIndex(list.Count);
                int index2 = source.GetIndex(list.Count);

                list.SwapValues(index1, index2);
            }

            return list;
        }
        static public IEnumerable<T> RandomizeSwaps<T>(this IEnumerable<T> item, int number_swaps)
        {
            return item.RandomizeSwaps(number_swaps, RandInt.SOURCE);
        }

        static public IEnumerable<T> OffsetRandom<T>(this IEnumerable<T> item, RandIntSource source, int limit=int.MaxValue)
        {
            List<T> list = item.ToList();

            list.RemoveBeginningRandom(source, limit);
            return list;
        }
        static public IEnumerable<T> OffsetRandom<T>(this IEnumerable<T> item, int limit=int.MaxValue)
        {
            return item.OffsetRandom(RandInt.SOURCE, limit);
        }

        static public IEnumerable<T> TruncateRandom<T>(this IEnumerable<T> item, RandIntSource source, int limit=0)
        {
            List<T> list = item.ToList();

            list.RemoveEndingRandom(source, limit);
            return list;
        }
        static public IEnumerable<T> TruncateRandom<T>(this IEnumerable<T> item, int limit=0)
        {
            return item.TruncateRandom(RandInt.SOURCE, limit);
        }
    }
}