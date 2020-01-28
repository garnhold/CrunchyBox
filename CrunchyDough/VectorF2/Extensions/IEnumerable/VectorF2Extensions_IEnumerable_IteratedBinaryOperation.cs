using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorF2Extensions_IEnumerable_IteratedBinaryOperation
    {
        static public VectorF2 Sum(this IEnumerable<VectorF2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2);
        }

        static public VectorF2 Average(this IEnumerable<VectorF2> item)
        {
            int count;

            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2, out count) / count;
        }

        static public VectorF2 Min(this IEnumerable<VectorF2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMin(v2));
        }

        static public VectorF2 Max(this IEnumerable<VectorF2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMax(v2));
        }

        static public VectorF2 DiminishingAverage(this IEnumerable<VectorF2> item, float ratio)
        {
            float current_weight = 1.0f;

            float total_weight = 0.0f;
            VectorF2 total = VectorF2.ZERO;

            foreach (VectorF2 sub_item in item)
            {
                total += sub_item * current_weight;
                total_weight += current_weight;

                current_weight *= ratio;
            }

            return total / total_weight;
        }
    }
}