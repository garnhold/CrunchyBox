using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorI2Extensions_IEnumerable_IteratedBinaryOperation
    {
        static public VectorI2 Sum(this IEnumerable<VectorI2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2);
        }

        static public VectorF2 Average(this IEnumerable<VectorI2> item)
        {
            int count;

            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2, out count) / (float)count;
        }

        static public VectorI2 Min(this IEnumerable<VectorI2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMin(v2));
        }

        static public VectorI2 Max(this IEnumerable<VectorI2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMax(v2));
        }
    }
}