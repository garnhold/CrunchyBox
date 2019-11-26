using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Approximate
    {
        static public int ApproximateEarliestEdge<T>(this IList<T> item, Predicate<T> predicate)
        {
            int index_a = 0;
            int index_b = item.Count;

            while (index_b - index_a > 1)
            {
                int index = (index_a + index_b) / 2;

                if (predicate(item[index]))
                    index_b = index;
                else
                    index_a = index;
            }

            return index_b;
        }
        static public bool TryApproximateEarliestEdge<T>(this IList<T> item, Predicate<T> predicate, out int earliest_index)
        {
            earliest_index = item.ApproximateEarliestEdge(predicate);

            return item.IsIndexValid(earliest_index);
        }
    }
}