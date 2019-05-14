using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_Ray
    {
        static public bool IntersectRay(this Plane item, Ray ray, out float distance)
        {
            if (item.IntersectBiRay(ray, out distance) && distance >= 0.0f)
                return true;

            distance = float.MaxValue;
            return false;
        }

        static public bool IntersectRay(this Plane item, Ray ray, out Vector3 point)
        {
            float distance;
            bool did_intersect = item.IntersectRay(ray, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect;
        }

        static public Vector3 IntersectRay(this Plane item, Ray ray)
        {
            Vector3 point;

            item.IntersectRay(ray, out point);
            return point;
        }
    }
}