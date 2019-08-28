using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Divvy
    {
        static public IEnumerable<IEnumerable<T>> Divvy<T>(this IEnumerable<T> item, IEnumerable<float> weights)
        {
            IList<T> item_list = item.PrepareForIndexing();
            ICollection<float> weights_collection = weights.PrepareForMultipass();

            int index = 0;
            int total_count = item_list.Count;
            float total_weight = weights_collection.Sum();

            foreach (float weight in weights_collection)
            {
                int count = (int)(total_count * (weight / total_weight) + 0.5f);

                yield return item_list.Sub(index, count);
                index += count;
            }
        }
    }
}