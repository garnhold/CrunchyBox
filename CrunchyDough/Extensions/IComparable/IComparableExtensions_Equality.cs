using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IComparableExtensions_Equality
    {
        static public bool IsEqualTo<T>(this T item, T value) where T : IComparable<T>
        {
            return item.CompareToEX(value).IsEqualTo();
        }
        static public bool IsNotEqualTo<T>(this T item, T value) where T : IComparable<T>
        {
            return item.CompareToEX(value).IsNotEqualTo();
        }

        static public bool IsLessThan<T>(this T item, T value) where T : IComparable<T>
        {
            return item.CompareToEX(value).IsLessThan();
        }
        static public bool IsLessThanOrEqualTo<T>(this T item, T value) where T : IComparable<T>
        {
            return item.CompareToEX(value).IsLessThanOrEqualTo();
        }

        static public bool IsGreaterThan<T>(this T item, T value) where T : IComparable<T>
        {
            return item.CompareToEX(value).IsGreaterThan();
        }
        static public bool IsGreaterThanOrEqualTo<T>(this T item, T value) where T : IComparable<T>
        {
            return item.CompareToEX(value).IsGreaterThanOrEqualTo();
        }
    }
}