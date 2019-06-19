using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_PercentCapped
    {
        static public void SetPercentCapped<T>(this IList<T> item, float percent, T value)
        {
            item.SetCapped(item.GetPercentIndex(percent), value);
        }

        static public T GetPercentCapped<T>(this IList<T> item, float percent)
        {
            return item.GetCapped(item.GetPercentIndex(percent));
        }
    }
}