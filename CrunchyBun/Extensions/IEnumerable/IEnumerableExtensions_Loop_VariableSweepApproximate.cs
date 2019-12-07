using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IEnumerableExtensions_Loop_VariableSweepApproximate
    {
        static public IEnumerable<T> VariableSweepApproximateLoop<T>(this IEnumerable<T> item, int maximum_length, double threshold, Operation<double, T, T, T> operation)
        {
            return item.VariableSweepApproximatePath(maximum_length, threshold, operation).ToList()
                .RotateHalfway()
                .VariableSweepApproximatePath(maximum_length, threshold, operation);
        }
    }
}