using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Unique
    {
        static public IEnumerable<T> Unique<T>(this IEnumerable<T> item)
        {
            return item.SkipDuplicates();
        }

        static public IDictionary<T, int> ItemizeUniques<T>(this IEnumerable<T> item)
        {
            Dictionary<T, int> dictionary = new Dictionary<T, int>();

            item.Process(i => dictionary.AddNumericValues(i, 1));
            return dictionary;
        }
    }
}