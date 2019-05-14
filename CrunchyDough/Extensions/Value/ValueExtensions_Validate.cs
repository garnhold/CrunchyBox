using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ValueExtensions_Validate
    {
        static public T Validate<T>(this T item, Predicate<T> predicate, T default_value)
        {
            if (predicate(item))
                return item;

            return default_value;
        }
        static public T Validate<T>(this T item, Predicate<T> predicate)
        {
            return item.Validate<T>(predicate, default(T));
        }
    }
}