using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Plane2Extensions_Intersect_Line
    {
        static public bool IsIntersectingLine(this Plane2 item, Ray2 ray, out float distance)
        {
            return ray.IsIntersectingLine(item.GetOrigin(), item.normal, out distance);
        }

        static public bool IsIntersectingLine(this Plane2 item, Ray2 ray, out Vector2 point)
        {
            float distance;
            bool did_intersect = item.IsIntersectingLine(ray, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect;
        }
    }
}