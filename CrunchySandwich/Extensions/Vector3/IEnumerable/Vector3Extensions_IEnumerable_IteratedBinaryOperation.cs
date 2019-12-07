using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector3Extensions_IEnumerable_IteratedBinaryOperation
    {
        static public Vector3 Sum(this IEnumerable<Vector3> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2);
        }

        static public Vector3 Average(this IEnumerable<Vector3> item)
        {
            int count;

            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2, out count) / count;
        }

        static public Vector3 Min(this IEnumerable<Vector3> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMin(v2));
        }

        static public Vector3 Max(this IEnumerable<Vector3> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMax(v2));
        }
    }
}