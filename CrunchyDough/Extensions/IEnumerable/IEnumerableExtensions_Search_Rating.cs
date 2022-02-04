using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_Rating
    {
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out T highest_rated, out double highest_rating, out int highest_rated_index)
        {
            int index = 0;
            bool found = false;

            highest_rated = default(T);
            highest_rating = double.MinValue;
            highest_rated_index = -1;

            foreach (T sub_item in item)
            {
                double current_rating = rater(sub_item);

                if (current_rating >= highest_rating)
                {
                    found = true;

                    highest_rated = sub_item;
                    highest_rating = current_rating;
                    highest_rated_index = index;
                }

                index++;
            }

            return found;
        }
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out T lowest_rated, out double lowest_rating, out int lowest_rated_index)
        {
            bool found = item.TryFindHighestRated<T>(delegate(T sub_item) {
                return -rater(sub_item);
            }, out lowest_rated, out lowest_rating, out lowest_rated_index);

            lowest_rating = -lowest_rating;
            return found;
        }
    }
}