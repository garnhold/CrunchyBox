using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_PercentLooped
    {
        static public void SetPercentLooped<T>(this IList<T> item, float percent, T value)
        {
            item.SetLooped(item.GetPercentIndex(percent), value);
        }

        static public T GetPercentLooped<T>(this IList<T> item, float percent)
        {
            return item.GetLooped(item.GetPercentIndex(percent));
        }
    }
}