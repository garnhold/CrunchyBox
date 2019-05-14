using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IComparableExtensions
    {
        static public CompareResult CompareToEX<T>(this T item, T value) where T : IComparable<T>
        {
            if (item != null)
                return CompareResultExtensions.CreateFromInt(item.CompareTo(value));

            if (value != null)
                return CompareResult.LessThan;

            return CompareResult.EqualTo;
        }
    }
}