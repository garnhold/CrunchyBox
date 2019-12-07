using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Unique
    {
        static public IEnumerable<T> Unique<T>(this IEnumerable<T> item)
        {
            return item.SkipDuplicates();
        }

        static public IEnumerable<T> Unique<T, J>(this IEnumerable<T> item, Operation<J, T> operation)
        {
            return item.SkipDuplicates(operation);
        }

        static public IDictionary<T, int> ItemizeUniques<T>(this IEnumerable<T> item)
        {
            Dictionary<T, int> dictionary = new Dictionary<T, int>();

            item.Process(i => dictionary.AddNumericValues(i, 1));
            return dictionary;
        }
    }
}