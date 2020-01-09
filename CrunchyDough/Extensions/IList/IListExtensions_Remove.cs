using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Remove
    {
        static public void RemoveSubSection<T>(this IList<T> item, int start, int end)
        {
            for(int i = end - 1; i >= start; i--)
                item.RemoveAt(i);
        }

        static public void RemoveSub<T>(this IList<T> item, int start, int length)
        {
            item.RemoveSubSection(start, start + length);
        }

        static public void RemoveBeginning<T>(this IList<T> item, int start)
        {
            item.RemoveSubSection(0, start);
        }

        static public void RemoveEnding<T>(this IList<T> item, int end)
        {
            item.RemoveSubSection(end, item.Count);
        }

        static public void RemoveTrim<T>(this IList<T> item, int amount)
        {
            item.RemoveEnding(item.Count - amount);
        }
    }
}