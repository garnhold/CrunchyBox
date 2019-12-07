using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Intersect_Line
    {
        static public bool IsIntersectingLine(this Plane item, Ray ray, out float distance)
        {
            return ray.IsIntersectingLine(item.GetOrigin(), item.normal, out distance);
        }

        static public bool IsIntersectingLine(this Plane item, Ray ray, out Vector3 point)
        {
            float distance;
            bool did_intersect = item.IsIntersectingLine(ray, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect;
        }

        static public Vector3 IntersectLine(this Plane item, Ray ray)
        {
            Vector3 point;

            item.IsIntersectingLine(ray, out point);
            return point;
        }
    }
}