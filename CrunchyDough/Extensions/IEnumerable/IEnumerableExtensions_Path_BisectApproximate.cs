using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class IEnumerableExtensions_Path_BisectApproximate
    {
        static public IEnumerable<T> BisectApproximatePath<T>(this IEnumerable<T> item, double threshold, Operation<double, T, T, T> operation)
        {
            return item.ToList().BisectApproximatePath(threshold, operation);
        }
        static public IEnumerable<T> BisectApproximatePath<T>(this IList<T> item, double threshold, Operation<double, T, T, T> operation)
        {
            if (item.Count >= 3)
            {
                T left_item = item.GetFirst();
                T right_item = item.GetLast();
                IList<T> inner = item.SubSection(1, item.Count - 1);

                T most_disruptive;
                int most_disruptive_index;

                yield return left_item;

                    if (inner.FindHighestRating(i => operation(left_item, right_item, i), out most_disruptive, out most_disruptive_index) >= threshold)
                    {
                        foreach (T sub_item in inner.Truncate(most_disruptive_index).BisectApproximatePath(threshold, operation))
                            yield return sub_item;

                        foreach (T sub_item in inner.Offset(most_disruptive_index).BisectApproximatePath(threshold, operation))
                            yield return sub_item;
                    }

                yield return right_item;
            }
            else
            {
                foreach (T sub_item in item)
                    yield return sub_item;
            }
        }
    }
}