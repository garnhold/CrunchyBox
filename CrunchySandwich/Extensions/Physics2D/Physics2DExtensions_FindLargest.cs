using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public partial class Physics2DExtensions
    {
        static public float FindLargestCircleFit(Vector2 position, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            if (Physics2D.OverlapPoint(position, layer_mask) == null)
            {
                if (Physics2D.OverlapCircle(position, maximum, layer_mask) == null)
                    return maximum;

                return Mathq.FindAnEdge(0.0f, maximum, r => Physics2D.OverlapCircle(position, r, layer_mask) == null, margin, max_iterations) - margin;
            }

            return 0.0f;
        }

        static public float FindLargestFixedEdgeCircleFit(Vector2 position, Vector2 direction, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            if (Physics2D.OverlapPoint(position, layer_mask) == null)
            {
                if (Physics2D.OverlapCircle(position + direction * maximum, maximum, layer_mask) == null)
                    return maximum;

                return Mathq.FindAnEdge(0.0f, maximum, r => Physics2D.OverlapCircle(position + direction * r, r, layer_mask) == null, margin, max_iterations) - margin;
            }

            return 0.0f;
        }

        static public float FindLargestCircleCast(Vector2 position, Vector2 direction, float distance, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            if (Physics2D.Raycast(position, direction, distance, layer_mask).DidHit() == false)
            {
                if (Physics2D.CircleCast(position, maximum, direction, distance, layer_mask).DidHit() == false)
                    return maximum;

                return Mathq.FindAnEdge(0.0f, maximum, r => Physics2D.CircleCast(position, r, direction, distance, layer_mask).DidHit(), margin, max_iterations) - margin;
            }

            return 0.0f;
        }

        static public float FindLargestFixedEdgeCircleCast(Vector2 position, Vector2 direction, float distance, float maximum, int layer_mask = IntBits.ALL_BITS, float margin = Mathq.DEFAULT_SOLVE_MARGIN, int max_iterations = Mathq.DEFAULT_SOLVE_MAX_NUMBER_ITERATIONS)
        {
            if (Physics2D.Raycast(position, direction, distance, layer_mask).DidHit() == false)
            {
                if (Physics2D.CircleCast(position, maximum, direction, distance, layer_mask).DidHit() == false)
                    return maximum;

                return Mathq.FindAnEdge(0.0f, maximum, r => Physics2D.CircleCast(position, r, direction, distance - r, layer_mask).DidHit(), margin, max_iterations) - margin;
            }

            return 0.0f;
        }
    }
}