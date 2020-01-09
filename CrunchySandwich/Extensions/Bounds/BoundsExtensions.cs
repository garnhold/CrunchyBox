using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions
    {
        static public readonly Bounds ZERO_BOUNDS = new Bounds(Vector3.zero, Vector3.zero);
        static public readonly Bounds ALL_BOUNDS = new Bounds(Vector3.zero, Vector3.positiveInfinity);

        static public Bounds CreateWithPoints(IEnumerable<Vector3> points)
        {
            return points.GetEncompassing();
        }
        static public Bounds CreateWithPoints(params Vector3[] points)
        {
            return CreateWithPoints((IEnumerable<Vector3>)points);
        }

        static public Bounds CreateMinMaxBounds(Vector3 min, Vector3 max)
        {
            Bounds bounds = new Bounds(min, Vector3.zero);

            bounds.Encapsulate(max);
            return bounds;
        }

        static public bool TryCreateStrictMinMaxBounds(Vector3 min, Vector3 max, out Bounds bounds)
        {
            if (min.x < max.x)
            {
                if (min.y < max.y)
                {
                    if (min.z < max.z)
                    {
                        bounds = CreateMinMaxBounds(min, max);
                        return true;
                    }
                }
            }

            bounds = ZERO_BOUNDS;
            return false;
        }
        static public Bounds CreateStrictMinMaxBounds(Vector3 min, Vector3 max)
        {
            Bounds bounds;

            TryCreateStrictMinMaxBounds(min, max, out bounds);
            return bounds;
        }

        static public Bounds CreateMinMaxAreaBounds(Vector2 min, Vector2 max, float height, float base_position)
        {
            return CreateMinMaxBounds(min.GetArear(base_position), max.GetArear(base_position + height));
        }

        static public Bounds CreateCenterAreaBounds(Vector2 center, Vector2 size, float height, float base_position)
        {
            Vector2 extents = size * 0.5f;

            return CreateMinMaxAreaBounds(center - extents, center + extents, height, base_position);
        }
    }
}