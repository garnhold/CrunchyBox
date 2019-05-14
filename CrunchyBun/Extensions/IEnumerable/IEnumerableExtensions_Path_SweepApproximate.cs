using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class IEnumerableExtensions_Path_SweepApproximate
    {
        static public IEnumerable<T> SweepApproximatePath<T>(this IEnumerable<T> item, int length, double threshold, Operation<double, List<T>> rate_operation, Operation<IEnumerable<T>, List<T>> collapse_operation)
        {
            return item.ToList().SweepApproximatePath(length, threshold, rate_operation, collapse_operation);
        }
        static public IEnumerable<T> SweepApproximatePath<T>(this IList<T> item, int length, double threshold, Operation<double, List<T>> rate_operation, Operation<IEnumerable<T>, List<T>> collapse_operation)
        {
            List<T> lowest_rated;
            double lowest_rating;
            int lowest_rated_index;

            if (item.TryFindLowestRatedSequence(length, rate_operation, out lowest_rated, out lowest_rating, out lowest_rated_index))
            {
                if (lowest_rating < threshold)
                {
                    return item.Truncate(lowest_rated_index)
                        .Append(collapse_operation(lowest_rated))
                        .Append(item.Offset(lowest_rated_index + length)).SweepApproximatePath(length, threshold, rate_operation, collapse_operation);
                }
            }

            return item;
        }
    }
}