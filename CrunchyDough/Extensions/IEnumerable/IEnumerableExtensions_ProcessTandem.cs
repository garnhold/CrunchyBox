using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_ProcessTandem
    {
        static public void ProcessTandemStrict<T, J>(this IEnumerable<T> item1, IEnumerable<J> item2, Process<T, J> process)
        {
            item1.PairStrict(item2).Process(t => process(t.item1, t.item2));
        }

        static public void ProcessTandemPermissive<T, J>(this IEnumerable<T> item1, IEnumerable<J> item2, Process<T, J> process)
        {
            item1.PairPermissive(item2).Process(t => process(t.item1, t.item2));
        }
    }
}