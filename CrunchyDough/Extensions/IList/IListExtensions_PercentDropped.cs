using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_PercentDropped
    {
        static public void SetPercentDropped<T>(this IList<T> item, float percent, T value)
        {
            item.SetDropped(item.GetPercentIndex(percent), value);
        }

        static public T GetPercentDropped<T>(this IList<T> item, float percent)
        {
            return item.GetDropped(item.GetPercentIndex(percent));
        }
    }
}