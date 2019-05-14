using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class IListExtensions_Get
    {
        static public float GetInterpolate(this IList<float> item, double index)
        {
            return item.GetInterpolate(index, (f1, f2, a) => f1.GetInterpolate(f2, (float)a));
        }

        static public float GetLoopedInterpolate(this IList<float> item, double index)
        {
            return item.GetLoopedInterpolate(index, (f1, f2, a) => f1.GetInterpolate(f2, (float)a));
        }
    }
}