using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
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

        static public IEnumerable<IEnumerable<T>> DivvyEvenly<T>(this IEnumerable<T> item, int number)
        {
            IList<T> item_list = item.PrepareForIndexing();

            int index = 0;
            int total_count = item_list.Count;
            int count_per = total_count / number;

            int number_minus_one = number - 1;

            for(int i = 0; i < number_minus_one; i++)
            {
                yield return item_list.Sub(index, count_per);
                index += count_per;
            }

            yield return item_list.Offset(index);
        }
    }
}