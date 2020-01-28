using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Sort
    {
        static public IEnumerable<T> Sort<T>(this IEnumerable<T> item, IComparer<T> comparer)
        {
            T[] array = item.ToArray();

            if(array.Length > 1)
                return array.SortInternal(0, array.Length, comparer);

            return array;
        }
        static private IEnumerable<T> SortInternal<T>(this T[] item, int start, int end, IComparer<T> comparer)
        {
            int center_start = (start + end) / 2;
            int center_end = center_start + 1;

            item.SortAbout(start, end, ref center_start, ref center_end, comparer);

            if (start < center_start)
            {
                foreach (T sub_item in item.SortInternal(start, center_start, comparer))
                    yield return sub_item;
            }

            for (int i = center_start; i < center_end; i++)
                yield return item[i];

            if (center_end < end)
            {
                foreach (T sub_item in item.SortInternal(center_end, end, comparer))
                    yield return sub_item;
            }
        }
        static private void SortAbout<T>(this T[] item, int start, int end, ref int center_start, ref int center_end, IComparer<T> comparer)
        {
            T center_value = item[center_start];

            int low_start = center_start - 1;
            int high_start = center_end;

            for (int i = low_start; i >= 0; i--)
            {
                T value = item[i];
                int result = comparer.Compare(value, center_value);

                if (result >= 0)
                {
                    int swap_index = center_start - 1;

                    item[i] = item[swap_index];

                    if (result > 0)
                    {
                        center_end--;

                        item[swap_index] = item[center_end];
                        item[center_end] = value;
                    }
                    else
                    {
                        item[swap_index] = value;
                    }

                    center_start--;
                }
            }

            for (int i = high_start; i < end; i++)
            {
                T value = item[i];
                int result = comparer.Compare(value, center_value);

                if (result <= 0)
                {
                    int swap_index = center_end;

                    item[i] = item[swap_index];

                    if (result < 0)
                    {
                        item[swap_index] = item[center_start];
                        item[center_start] = value;

                        center_start++;
                    }
                    else
                    {
                        item[swap_index] = value;
                    }

                    center_end++;
                }
            }
        }

        static public IEnumerable<T> Sort<T>(this IEnumerable<T> item, Comparison<T> comparison)
        {
            return item.Sort(new ComparisonComparer<T>(comparison));
        }

        static public IEnumerable<T> Sort<T, J>(this IEnumerable<T> item, Operation<J, T> getter) where J : IComparable
        {
            return item.Sort((x, y) => getter(x).CompareTo(getter(y)));
        }
        static public IEnumerable<T> Sort<T>(this IEnumerable<T> item) where T : IComparable
        {
            return item.Sort((x, y) => x.CompareTo(y));
        }
    }
}