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

                yield return left_item;

                    foreach (T sub_item in inner.BisectApproximateInnerPath(left_item, right_item, threshold, operation))
                        yield return sub_item;

                yield return right_item;
            }
            else
            {
                foreach (T sub_item in item)
                    yield return sub_item;
            }
        }
        static public IEnumerable<T> BisectApproximateInnerPath<T>(this IList<T> item, T left_item, T right_item, double threshold, Operation<double, T, T, T> operation)
        {
            T most_disruptive;
            int most_disruptive_index;

            if (item.FindHighestRating(i => operation(left_item, right_item, i), out most_disruptive, out most_disruptive_index) >= threshold)
            {
                foreach (T sub_item in item.SubSection(0, most_disruptive_index).BisectApproximateInnerPath(left_item, most_disruptive, threshold, operation))
                    yield return sub_item;

                yield return most_disruptive;

                foreach (T sub_item in item.SubSection(most_disruptive_index + 1, item.Count).BisectApproximateInnerPath(most_disruptive, right_item, threshold, operation))
                    yield return sub_item;
            }
        }
    }
}
