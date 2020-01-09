using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Segment
    {
        static public IEnumerable<T> Segment<T>(this IEnumerable<T> item)
        {
            foreach (Tuple<T, T> tuple in item.ConvertConnections())
            {
                yield return tuple.item1;
                yield return tuple.item2;
            }
        }
    }
}