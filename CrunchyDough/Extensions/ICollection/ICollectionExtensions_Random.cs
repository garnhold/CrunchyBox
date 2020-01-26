using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class ICollectionExtensions_Random
    {
        static public T GetRandom<T>(this ICollection<T> item, RandIntSource source)
        {
            return item.Get(source.GetIndex(item.Count));
        }
        static public T GetRandom<T>(this ICollection<T> item)
        {
            return item.GetRandom(RandInt.SOURCE);
        }

        static public IEnumerable<T> GetMultipleRandom<T>(this ICollection<T> item, int count, RandIntSource source)
        {
            for (int i = 0; i < count; i++)
                yield return item.GetRandom(source);
        }
        static public IEnumerable<T> GetMultipleRandom<T>(this ICollection<T> item, int count)
        {
            return item.GetMultipleRandom(count, RandInt.SOURCE);
        }
    }
}