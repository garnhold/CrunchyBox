using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Plane2Extensions_BiRay
    {
        static public bool IntersectBiRay(this Plane2 item, Ray2 ray, out float distance)
        {
            return ray.IntersectsGeneralBi(item.GetOrigin(), item.normal, out distance);
        }

        static public bool IntersectBiRay(this Plane2 item, Ray2 ray, out Vector2 point)
        {
            float distance;
            bool did_intersect = item.IntersectBiRay(ray, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect;
        }
    }
}