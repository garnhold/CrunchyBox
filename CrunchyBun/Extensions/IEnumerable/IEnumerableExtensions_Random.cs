using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IEnumerableExtensions_Random
    {
        static public IEnumerable<T> Randomize<T>(this IEnumerable<T> item, RandIntSource source)
        {
            List<T> list = item.ToList();

            list.Shuffle();
            return list;
        }
        static public IEnumerable<T> Randomize<T>(this IEnumerable<T> item)
        {
            return item.Randomize(RandInt.SOURCE);
        }
    }
}