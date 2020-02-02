using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Shift
    {
        static public void ShiftElements<T>(this IList<T> item, int start, int end, int amount)
        {
            if (amount != 0)
            {
                start = item.GetCappedIndex(start);
                end = item.GetCappedIndex(end);

                if (amount > 0)
                {
                    for (int i = end; i > start; i--)
                        item[i] = item[i - amount];
                }
                else
                {
                    for (int i = start; i < end; i++)
                        item[i] = item[i - amount];
                }
            }
        }

        static public void ShiftElements<T>(this IList<T> item, int start, int amount)
        {
            item.ShiftElements<T>(start, item.Count(), amount);
        }

        static public void ShiftUpInsert<T>(this IList<T> item, int index, T value)
        {
            item.ShiftElements<T>(index, 1);
            item.SetDropped(index, value);
        }

        static public void ShiftDownInsert<T>(this IList<T> item, int index, T value)
        {
            item.ShiftElements<T>(index, -1);
            item.SetDropped(index, value);
        }
    }
}