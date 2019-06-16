using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Plane2Extensions_Intersect_Ray
    {
        static public bool IsIntersecting(this Plane2 item, Ray2 ray, out float distance)
        {
            if (item.IsIntersectingLine(ray, out distance) && distance >= 0.0f)
                return true;

            return false;
        }

        static public bool IsIntersecting(this Plane2 item, Ray2 ray, out Vector2 point)
        {
            float distance;
            bool did_intersect = item.IsIntersecting(ray, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect;
        }
    }
}