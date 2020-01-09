using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IEnumerableExtensions_Path_VariableSweepApproximate
    {
        static public IEnumerable<T> VariableSweepApproximatePath<T>(this IEnumerable<T> item, int maximum_length, double threshold, Operation<double, T, T, T> operation)
        {
            return item.ToList().VariableSweepApproximatePath(maximum_length, threshold, operation);
        }
        static public IEnumerable<T> VariableSweepApproximatePath<T>(this IList<T> item, int maximum_length, double threshold, Operation<double, T, T, T> operation)
        {
            for (int length = maximum_length.Min(item.Count); length >= 3; length--)
            {
                List<T> lowest_rated;
                double lowest_rating;
                int lowest_rated_index;

                if (item.TryFindLowestRatedSequence(length, delegate(List<T> sequence) {
                    return sequence.SubSection(1, sequence.Count - 1).FindHighestRating(i => operation(sequence.GetFirst(), sequence.GetLast(), i));
                }, out lowest_rated, out lowest_rating, out lowest_rated_index))
                {
                    if (lowest_rating < threshold)
                    {
                        return item.Truncate(lowest_rated_index)
                            .Append(lowest_rated.GetFirst(), lowest_rated.GetLast())
                            .Append(item.Offset(lowest_rated_index + length)).VariableSweepApproximatePath(length, threshold, operation);
                    }
                }
            }

            return item;
        }
    }
}