using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_SequenceRating
    {
        static public bool TryFindHighestRatedSequence<T>(this IEnumerable<T> item, int length, Operation<double, List<T>> rater, out List<T> highest_rated, out double highest_rating, out int highest_rated_index)
        {
            int index = 0;

            highest_rated = null;
            highest_rating = double.MinValue;
            highest_rated_index = -1;

            foreach (List<T> sequence in item.GetSequences(length))
            {
                double current_rating = rater(sequence);

                if (current_rating >= highest_rating)
                {
                    highest_rated = new List<T>(sequence);
                    highest_rating = current_rating;
                    highest_rated_index = index;
                }

                index++;
            }

            if (highest_rated_index == -1)
                return false;

            return true;
        }
        static public bool TryFindLowestRatedSequence<T>(this IEnumerable<T> item, int length, Operation<double, List<T>> rater, out List<T> lowest_rated, out double lowest_rating, out int lowest_rated_index)
        {
            bool return_value = item.TryFindHighestRatedSequence<T>(length, delegate(List<T> sub_item) {
                return -rater(sub_item);
            }, out lowest_rated, out lowest_rating, out lowest_rated_index);

            lowest_rating = -lowest_rating;
            return return_value;
        }
    }
}