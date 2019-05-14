using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IComparableExtensions_Binding
    {
        static public T BindBetween<T>(this T item, T value1, T value2) where T : IComparable<T>
        {
            T low;
            T high;

            value1.Order(value2, out low, out high);

            if (item.IsLessThan(low))
                return low;

            if (item.IsGreaterThan(high))
                return high;

            return item;
        }

        static public T BindAbove<T>(this T item, T value) where T : IComparable<T>
        {
            if (item.IsLessThan(value))
                return value;

            return item;
        }

        static public T BindBelow<T>(this T item, T value) where T : IComparable<T>
        {
            if (item.IsGreaterThan(value))
                return value;

            return item;
        }
    }
}