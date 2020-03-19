using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class FloatExtensions_IList
    {
        static public float GetInterpolate(this IList<float> item, double index)
        {
            return item.GetInterpolate(index, (f1, f2, a) => f1.GetInterpolate(f2, (float)a));
        }

        static public float GetCappedInterpolate(this IList<float> item, double index)
        {
            return item.GetCappedInterpolate(index, (f1, f2, a) => f1.GetInterpolate(f2, (float)a));
        }

        static public float GetLoopedInterpolate(this IList<float> item, double index)
        {
            return item.GetLoopedInterpolate(index, (f1, f2, a) => f1.GetInterpolate(f2, (float)a));
        }
    }
}