using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Looped
    {
        static public int GetLoopedIndex<T>(this IList<T> item, int index)
        {
            return index.GetLooped(item.Count);
        }

        static public void SetLooped<T>(this IList<T> item, int index, T value)
        {
            item[item.GetLoopedIndex(index)] = value;
        }

        static public T GetLooped<T>(this IList<T> item, int index)
        {
            return item[item.GetLoopedIndex(index)];
        }
    }
}