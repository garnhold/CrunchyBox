using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class LineSegment2Extensions_FindLargest
    {
        static public float FindLargestCircleCast(this LineSegment2 item, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return item.GetRay().FindLargestCircleCast(item.GetLength(), maximum, layer_mask, margin, max_iterations);
        }

        static public float FindLargestFixedEdgeCircleCast(this LineSegment2 item, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return item.GetRay().FindLargestFixedEdgeCircleCast(item.GetLength(), maximum, layer_mask, margin, max_iterations);
        }
    }
}