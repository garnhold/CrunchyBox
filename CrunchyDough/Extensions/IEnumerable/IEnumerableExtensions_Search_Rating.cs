using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_Rating
    {
        //Generic
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out T highest_rated, out int highest_rating, out int highest_rated_index)
        {
            int index = 0;
            bool found = false;

            highest_rated = default(T);
            highest_rating = int.MinValue;
            highest_rated_index = -1;

            foreach (T sub_item in item)
            {
                int current_rating = rater(sub_item);

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
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out T lowest_rated, out int lowest_rating, out int lowest_rated_index)
        {
            bool found = item.TryFindHighestRated<T>(delegate(T sub_item) {
                return -rater(sub_item);
            }, out lowest_rated, out lowest_rating, out lowest_rated_index);

            lowest_rating = -lowest_rating;
            return found;
        }
        
        //Highest
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out T highest_rated)
        {
            int highest_rated_index;
            int highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRating<T>(this IEnumerable<T> item, Operation<int, T> rater, out int highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRatedIndex<T>(this IEnumerable<T> item, Operation<int, T> rater, out int highest_rated_index)
        {
            T highest_rated;
            int highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }

        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int highest_rating, out int highest_rated_index)
        {
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater)
        {
            T highest_rated;
            int highest_rated_index;
            int highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }

        static public int FindHighestRating<T>(this IEnumerable<T> item, Operation<int, T> rater, out T highest_rated, out int highest_rated_index)
        {
            int highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public int FindHighestRating<T>(this IEnumerable<T> item, Operation<int, T> rater, out T highest_rated)
        {
            int highest_rating;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public int FindHighestRating<T>(this IEnumerable<T> item, Operation<int, T> rater)
        {
            int highest_rating;
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }

        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int highest_rating, out T highest_rated)
        {
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int highest_rating)
        {
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<int, T> rater)
        {
            int highest_rated_index;
            T highest_rated;
            int highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        
        //Lowest
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out T lowest_rated)
        {
            int lowest_rated_index;
            int lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRating<T>(this IEnumerable<T> item, Operation<int, T> rater, out int lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRatedIndex<T>(this IEnumerable<T> item, Operation<int, T> rater, out int lowest_rated_index)
        {
            T lowest_rated;
            int lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }

        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int lowest_rating, out int lowest_rated_index)
        {
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater)
        {
            T lowest_rated;
            int lowest_rated_index;
            int lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }

        static public int FindLowestRating<T>(this IEnumerable<T> item, Operation<int, T> rater, out T lowest_rated, out int lowest_rated_index)
        {
            int lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public int FindLowestRating<T>(this IEnumerable<T> item, Operation<int, T> rater, out T lowest_rated)
        {
            int lowest_rating;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public int FindLowestRating<T>(this IEnumerable<T> item, Operation<int, T> rater)
        {
            int lowest_rating;
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }

        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int lowest_rating, out T lowest_rated)
        {
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater, out int lowest_rating)
        {
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<int, T> rater)
        {
            int lowest_rated_index;
            T lowest_rated;
            int lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        //Generic
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out T highest_rated, out long highest_rating, out int highest_rated_index)
        {
            int index = 0;
            bool found = false;

            highest_rated = default(T);
            highest_rating = long.MinValue;
            highest_rated_index = -1;

            foreach (T sub_item in item)
            {
                long current_rating = rater(sub_item);

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
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out T lowest_rated, out long lowest_rating, out int lowest_rated_index)
        {
            bool found = item.TryFindHighestRated<T>(delegate(T sub_item) {
                return -rater(sub_item);
            }, out lowest_rated, out lowest_rating, out lowest_rated_index);

            lowest_rating = -lowest_rating;
            return found;
        }
        
        //Highest
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out T highest_rated)
        {
            int highest_rated_index;
            long highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRating<T>(this IEnumerable<T> item, Operation<long, T> rater, out long highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRatedIndex<T>(this IEnumerable<T> item, Operation<long, T> rater, out int highest_rated_index)
        {
            T highest_rated;
            long highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }

        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long highest_rating, out int highest_rated_index)
        {
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater)
        {
            T highest_rated;
            int highest_rated_index;
            long highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }

        static public long FindHighestRating<T>(this IEnumerable<T> item, Operation<long, T> rater, out T highest_rated, out int highest_rated_index)
        {
            long highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public long FindHighestRating<T>(this IEnumerable<T> item, Operation<long, T> rater, out T highest_rated)
        {
            long highest_rating;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public long FindHighestRating<T>(this IEnumerable<T> item, Operation<long, T> rater)
        {
            long highest_rating;
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }

        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long highest_rating, out T highest_rated)
        {
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long highest_rating)
        {
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<long, T> rater)
        {
            int highest_rated_index;
            T highest_rated;
            long highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        
        //Lowest
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out T lowest_rated)
        {
            int lowest_rated_index;
            long lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRating<T>(this IEnumerable<T> item, Operation<long, T> rater, out long lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRatedIndex<T>(this IEnumerable<T> item, Operation<long, T> rater, out int lowest_rated_index)
        {
            T lowest_rated;
            long lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }

        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long lowest_rating, out int lowest_rated_index)
        {
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater)
        {
            T lowest_rated;
            int lowest_rated_index;
            long lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }

        static public long FindLowestRating<T>(this IEnumerable<T> item, Operation<long, T> rater, out T lowest_rated, out int lowest_rated_index)
        {
            long lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public long FindLowestRating<T>(this IEnumerable<T> item, Operation<long, T> rater, out T lowest_rated)
        {
            long lowest_rating;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public long FindLowestRating<T>(this IEnumerable<T> item, Operation<long, T> rater)
        {
            long lowest_rating;
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }

        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long lowest_rating, out T lowest_rated)
        {
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater, out long lowest_rating)
        {
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<long, T> rater)
        {
            int lowest_rated_index;
            T lowest_rated;
            long lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        //Generic
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out T highest_rated, out float highest_rating, out int highest_rated_index)
        {
            int index = 0;
            bool found = false;

            highest_rated = default(T);
            highest_rating = float.MinValue;
            highest_rated_index = -1;

            foreach (T sub_item in item)
            {
                float current_rating = rater(sub_item);

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
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out T lowest_rated, out float lowest_rating, out int lowest_rated_index)
        {
            bool found = item.TryFindHighestRated<T>(delegate(T sub_item) {
                return -rater(sub_item);
            }, out lowest_rated, out lowest_rating, out lowest_rated_index);

            lowest_rating = -lowest_rating;
            return found;
        }
        
        //Highest
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out T highest_rated)
        {
            int highest_rated_index;
            float highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRating<T>(this IEnumerable<T> item, Operation<float, T> rater, out float highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRatedIndex<T>(this IEnumerable<T> item, Operation<float, T> rater, out int highest_rated_index)
        {
            T highest_rated;
            float highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }

        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float highest_rating, out int highest_rated_index)
        {
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater)
        {
            T highest_rated;
            int highest_rated_index;
            float highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }

        static public float FindHighestRating<T>(this IEnumerable<T> item, Operation<float, T> rater, out T highest_rated, out int highest_rated_index)
        {
            float highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public float FindHighestRating<T>(this IEnumerable<T> item, Operation<float, T> rater, out T highest_rated)
        {
            float highest_rating;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public float FindHighestRating<T>(this IEnumerable<T> item, Operation<float, T> rater)
        {
            float highest_rating;
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }

        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float highest_rating, out T highest_rated)
        {
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float highest_rating)
        {
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<float, T> rater)
        {
            int highest_rated_index;
            T highest_rated;
            float highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        
        //Lowest
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out T lowest_rated)
        {
            int lowest_rated_index;
            float lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRating<T>(this IEnumerable<T> item, Operation<float, T> rater, out float lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRatedIndex<T>(this IEnumerable<T> item, Operation<float, T> rater, out int lowest_rated_index)
        {
            T lowest_rated;
            float lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }

        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float lowest_rating, out int lowest_rated_index)
        {
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater)
        {
            T lowest_rated;
            int lowest_rated_index;
            float lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }

        static public float FindLowestRating<T>(this IEnumerable<T> item, Operation<float, T> rater, out T lowest_rated, out int lowest_rated_index)
        {
            float lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public float FindLowestRating<T>(this IEnumerable<T> item, Operation<float, T> rater, out T lowest_rated)
        {
            float lowest_rating;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public float FindLowestRating<T>(this IEnumerable<T> item, Operation<float, T> rater)
        {
            float lowest_rating;
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }

        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float lowest_rating, out T lowest_rated)
        {
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater, out float lowest_rating)
        {
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<float, T> rater)
        {
            int lowest_rated_index;
            T lowest_rated;
            float lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        //Generic
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
        
        //Highest
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
        
        //Lowest
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out T lowest_rated)
        {
            int lowest_rated_index;
            double lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRatedIndex<T>(this IEnumerable<T> item, Operation<double, T> rater, out int lowest_rated_index)
        {
            T lowest_rated;
            double lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }

        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating, out int lowest_rated_index)
        {
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            T lowest_rated;
            int lowest_rated_index;
            double lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }

        static public double FindLowestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out T lowest_rated, out int lowest_rated_index)
        {
            double lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public double FindLowestRating<T>(this IEnumerable<T> item, Operation<double, T> rater, out T lowest_rated)
        {
            double lowest_rating;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public double FindLowestRating<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            double lowest_rating;
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }

        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating, out T lowest_rated)
        {
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater, out double lowest_rating)
        {
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<double, T> rater)
        {
            int lowest_rated_index;
            T lowest_rated;
            double lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        //Generic
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T highest_rated, out decimal highest_rating, out int highest_rated_index)
        {
            int index = 0;
            bool found = false;

            highest_rated = default(T);
            highest_rating = decimal.MinValue;
            highest_rated_index = -1;

            foreach (T sub_item in item)
            {
                decimal current_rating = rater(sub_item);

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
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T lowest_rated, out decimal lowest_rating, out int lowest_rated_index)
        {
            bool found = item.TryFindHighestRated<T>(delegate(T sub_item) {
                return -rater(sub_item);
            }, out lowest_rated, out lowest_rating, out lowest_rated_index);

            lowest_rating = -lowest_rating;
            return found;
        }
        
        //Highest
        static public bool TryFindHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T highest_rated)
        {
            int highest_rated_index;
            decimal highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }
        static public bool TryFindHighestRatedIndex<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out int highest_rated_index)
        {
            T highest_rated;
            decimal highest_rating;

            return item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
        }

        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal highest_rating, out int highest_rated_index)
        {
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal highest_rating)
        {
            T highest_rated;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }
        static public T FindHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater)
        {
            T highest_rated;
            int highest_rated_index;
            decimal highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated;
        }

        static public decimal FindHighestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T highest_rated, out int highest_rated_index)
        {
            decimal highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public decimal FindHighestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T highest_rated)
        {
            decimal highest_rating;
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }
        static public decimal FindHighestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater)
        {
            decimal highest_rating;
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rating;
        }

        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal highest_rating, out T highest_rated)
        {
            int highest_rated_index;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal highest_rating)
        {
            int highest_rated_index;
            T highest_rated;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        static public int FindIndexOfHighestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater)
        {
            int highest_rated_index;
            T highest_rated;
            decimal highest_rating;

            item.TryFindHighestRated(rater, out highest_rated, out highest_rating, out highest_rated_index);
            return highest_rated_index;
        }
        
        //Lowest
        static public bool TryFindLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T lowest_rated)
        {
            int lowest_rated_index;
            decimal lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }
        static public bool TryFindLowestRatedIndex<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out int lowest_rated_index)
        {
            T lowest_rated;
            decimal lowest_rating;

            return item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
        }

        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal lowest_rating, out int lowest_rated_index)
        {
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal lowest_rating)
        {
            T lowest_rated;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }
        static public T FindLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater)
        {
            T lowest_rated;
            int lowest_rated_index;
            decimal lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated;
        }

        static public decimal FindLowestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T lowest_rated, out int lowest_rated_index)
        {
            decimal lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public decimal FindLowestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out T lowest_rated)
        {
            decimal lowest_rating;
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }
        static public decimal FindLowestRating<T>(this IEnumerable<T> item, Operation<decimal, T> rater)
        {
            decimal lowest_rating;
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rating;
        }

        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal lowest_rating, out T lowest_rated)
        {
            int lowest_rated_index;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater, out decimal lowest_rating)
        {
            int lowest_rated_index;
            T lowest_rated;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
        static public int FindIndexOfLowestRated<T>(this IEnumerable<T> item, Operation<decimal, T> rater)
        {
            int lowest_rated_index;
            T lowest_rated;
            decimal lowest_rating;

            item.TryFindLowestRated(rater, out lowest_rated, out lowest_rating, out lowest_rated_index);
            return lowest_rated_index;
        }
    }
}

