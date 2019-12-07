using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Capped
    {
        static public int GetCappedIndex<T>(this IList<T> item, int index)
        {
            return index.BindBetween(0, item.GetFinalIndex());
        }

        static public void SetCapped<T>(this IList<T> item, int index, T value)
        {
            item.SetDropped(item.GetCappedIndex(index), value);
        }

        static public T GetCapped<T>(this IList<T> item, int index)
        {
            return item.GetDropped(item.GetCappedIndex(index));
        }
    }
}