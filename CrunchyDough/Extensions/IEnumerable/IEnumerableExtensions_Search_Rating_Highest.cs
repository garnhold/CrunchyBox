using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_Rating_Highest
    {
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out T highest_rated)
        {
            int highest_rated_index;
            double highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out double highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRatedIndex<T>(this IEnumerable<T> item, Operation<double, T> rater, out int highest_rated_index)
        {
            T highest_rated;
            double highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }

        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double highest_rating, out int highest_rated_index)
        {
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            T highest_rated;
            int highest_rated_index;
            double highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }

        static public double FindHighestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out T highest_rated, out int highest_rated_index)
        {
            double highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public double FindHighestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out T highest_rated)
        {
            double highest_rating;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public double FindHighestRating<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            double highest_rating;
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }

        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double highest_rating, out T highest_rated)
        {
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double highest_rating)
        {
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            int highest_rated_index;
            T highest_rated;
            double highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
    }
}