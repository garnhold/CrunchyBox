using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Ray2Extensions_FindLargest
    {
        static public float FindLargestCircleCast(this Ray2 item, float distance, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Physics2DExtensions.FindLargestCircleCast(item.origin, item.direction, distance, maximum, layer_mask, margin, max_iterations);
        }

        static public float FindLargestFixedEdgeCircleCast(this Ray2 item, float distance, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            return Physics2DExtensions.FindLargestFixedEdgeCircleCast(item.origin, item.direction, distance, maximum, layer_mask, margin, max_iterations);
        }
    }
}