using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RayLine2Extensions_FindLargest
    {
        static public float FindLargestCircleCast(this RayLine2 item, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return item.GetRay().FindLargestCircleCast(item.GetLength(), maximum, layer_mask, margin, max_iterations);
        }

        static public float FindLargestFixedEdgeCircleCast(this RayLine2 item, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return item.GetRay().FindLargestFixedEdgeCircleCast(item.GetLength(), maximum, layer_mask, margin, max_iterations);
        }
    }
}