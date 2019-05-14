using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Rating_Lowest
    {
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating, out int lowest_rated_index)
        {
            T lowest_rated;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            T lowest_rated;
            int lowest_rated_index;
            double lowest_rating;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }

        static public double FindLowestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out T lowest_rated, out int lowest_rated_index)
        {
            double lowest_rating;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public double FindLowestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out T lowest_rated)
        {
            double lowest_rating;
            int lowest_rated_index;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public double FindLowestRating<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            double lowest_rating;
            int lowest_rated_index;
            T lowest_rated;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }

        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating, out T lowest_rated)
        {
            int lowest_rated_index;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating)
        {
            int lowest_rated_index;
            T lowest_rated;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            int lowest_rated_index;
            T lowest_rated;
            double lowest_rating;

            item.FindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
    }
}