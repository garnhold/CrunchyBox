using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_RatingAll
    {
        static public IList<T> FindAllHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            List<T> highest_rated = new List<T>();
            double highest_rating = double.MinValue;

            foreach (T sub_item in item)
            {
                double current_rating = rater(sub_item);

                if (current_rating >= highest_rating)
                {
                    if(current_rating > highest_rating)
                    {
                        highest_rated.Clear();
                        highest_rating = current_rating;
                    }

                    highest_rated.Add(sub_item);
                }
            }

            return highest_rated;
        }
        static public IList<T> FindAllLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            return item.FindAllHighestRated<T>(delegate(T sub_item) {
                return -rater(sub_item);
            });
        }
    }
}