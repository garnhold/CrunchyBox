using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class IListExtensions_Random
    {
        static public T GetRandom<T>(this IList<T> item, RandIntSource source)
        {
            return item.Get(source.GetIndex(item.Count));
        }
        static public T GetRandom<T>(this IList<T> item)
        {
            return item.GetRandom(RandInt.SOURCE);
        }

        static public T PopRandom<T>(this IList<T> item, RandIntSource source)
        {
            return item.PopAt(source.GetIndex(item.Count));
        }
        static public T PopRandom<T>(this IList<T> item)
        {
            return item.PopRandom(RandInt.SOURCE);
        }

        static public IEnumerable<T> GetMultipleRandom<T>(this IList<T> item, int count, RandIntSource source)
        {
            for (int i = 0; i < count; i++)
                yield return item.GetRandom(source);
        }
        static public IEnumerable<T> GetMultipleRandom<T>(this IList<T> item, int count)
        {
            return item.GetMultipleRandom(count, RandInt.SOURCE);
        }
    }
}