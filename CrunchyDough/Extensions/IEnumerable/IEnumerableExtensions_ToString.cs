using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_ToString
    {
        static public string ToString<T>(this IEnumerable<T> item, string seperator)
        {
            return item.Convert(i => i.ToStringEX()).Join(seperator);
        }

        static public string ToString<T>(this IEnumerable<IEnumerable<T>> item, string seperator, string enumerable_seperator)
        {
            return item.Convert(i => i.ToString(seperator)).Join(enumerable_seperator);
        }
    }
}