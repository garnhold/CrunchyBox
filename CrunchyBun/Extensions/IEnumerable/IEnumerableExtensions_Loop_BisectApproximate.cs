using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class IEnumerableExtensions_Loop_BisectApproximate
    {
        static public IEnumerable<T> BisectApproximateLoop<T>(this IEnumerable<T> item, double threshold, Operation<double, T, T, T> operation)
        {
            return item.BisectApproximatePath(threshold, operation).ToList()
                .RotateHalfway()
                .BisectApproximatePath(threshold, operation);
        }
    }
}