using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ProcessConnections
    {
        static public void ProcessConnections<T>(this IEnumerable<T> item, Process<T, T> process)
        {
            item.ConvertConnections((v1, v2) => Tuple.New(v1, v2)).Process(t => process(t.item1, t.item2));
        }
    }
}