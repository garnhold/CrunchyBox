using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IComparableExtensions_MinMax
    {
        static public void Order<T>(this T item, T input, out T low, out T high) where T : IComparable<T>
        {
            if (item.IsLessThan(input))
            {
                low = item;
                high = input;
            }
            else
            {
                low = input;
                high = item;
            }
        }

        static public T Min<T>(this T item, T input) where T : IComparable<T>
        {
            if (input.IsLessThan(item))
                return input;

            return item;
        }

        static public T Max<T>(this T item, T input) where T : IComparable<T>
        {
            if (input.IsGreaterThan(item))
                return input;

            return item;
        }
    }
}