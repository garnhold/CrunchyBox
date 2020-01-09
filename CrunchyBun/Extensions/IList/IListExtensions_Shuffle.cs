using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IListExtensions_Shuffle
    {
        static public void Shuffle<T>(this IList<T> item, RandIntSource source)
        {
            for (int i = 0; i < item.Count; i++)
                item.SwapValues(i, source.GetBetween(i, item.Count));
        }
        static public void Shuffle<T>(this IList<T> item)
        {
            item.Shuffle(RandInt.SOURCE);
        }
    }
}