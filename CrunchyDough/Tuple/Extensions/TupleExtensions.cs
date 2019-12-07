using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TupleExtensions
    {
        static public KeyValuePair<T1, T2> ConvertToKeyValuePair<T1, T2>(this Tuple<T1, T2> item)
        {
            return KeyValuePair.New(item.item1, item.item2);
        }

        static public IEnumerable<KeyValuePair<T1, T2>> ConvertToKeyValuePairs<T1, T2>(this IEnumerable<Tuple<T1, T2>> item)
        {
            return item.Convert(t => t.ConvertToKeyValuePair());
        }
    }
}