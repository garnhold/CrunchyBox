using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_Intersect_Ray
    {
        static public bool IsIntersecting(this Plane item, Ray ray, out float distance)
        {
            if (item.IsIntersectingLine(ray, out distance) && distance >= 0.0f)
                return true;

            distance = float.MaxValue;
            return false;
        }

        static public bool IsIntersecting(this Plane item, Ray ray, out Vector3 point)
        {
            float distance;
            bool did_intersect = item.IsIntersecting(ray, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect;
        }

        static public Vector3 Intersect(this Plane item, Ray ray)
        {
            Vector3 point;

            item.IsIntersecting(ray, out point);
            return point;
        }
    }
}