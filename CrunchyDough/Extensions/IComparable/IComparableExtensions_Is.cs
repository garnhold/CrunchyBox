using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IComparableExtensions_Is
    {
        static public bool IsBoundBetween<T>(this T item, T value1, T value2) where T : IComparable<T>
        {
            T low;
            T high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
        }

        static public bool IsBoundAbove<T>(this T item, T lower) where T : IComparable<T>
        {
            if (item.IsGreaterThanOrEqualTo(lower))
                return true;

            return false;
        }

        static public bool IsBoundBelow<T>(this T item, T upper) where T : IComparable<T>
        {
            if (item.IsLessThanOrEqualTo(upper))
                return true;

            return false;
        }
    }
}