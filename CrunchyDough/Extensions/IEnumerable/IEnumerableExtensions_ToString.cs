using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_ToString
    {
        static public string ToString<T>(this IEnumerable<T> item, string seperator, string null_string = "")
        {
            return item.Convert(i => i.ToStringEX(null_string)).Join(seperator);
        }

        static public string ToString<T>(this IEnumerable<IEnumerable<T>> item, string seperator, string enumerable_seperator, string null_string = "")
        {
            return item.Convert(i => i.ToString(seperator, null_string)).Join(enumerable_seperator);
        }
    }
}