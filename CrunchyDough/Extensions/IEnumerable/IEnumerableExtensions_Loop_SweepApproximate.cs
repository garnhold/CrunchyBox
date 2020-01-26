using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class IEnumerableExtensions_Loop_SweepApproximate
    {
        static public IEnumerable<T> SweepApproximateLoop<T>(this IEnumerable<T> item, int length, double threshold, Operation<double, List<T>> rate_operation, Operation<IEnumerable<T>, List<T>> collapse_operation)
        {
            return item.SweepApproximatePath(length, threshold, rate_operation, collapse_operation).ToList()
                .RotateHalfway()
                .SweepApproximatePath(length, threshold, rate_operation, collapse_operation);
        }
    }
}