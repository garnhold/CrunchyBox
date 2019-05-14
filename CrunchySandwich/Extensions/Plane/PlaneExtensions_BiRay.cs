using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_BiRay
    {
        static public bool IntersectBiRay(this Plane item, Ray ray, out float distance)
        {
            return ray.IntersectsGeneralBi(item.GetOrigin(), item.normal, out distance);
        }

        static public bool IntersectBiRay(this Plane item, Ray ray, out Vector3 point)
        {
            float distance;
            bool did_intersect = item.IntersectBiRay(ray, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect;
        }

        static public Vector3 IntersectBiRay(this Plane item, Ray ray)
        {
            Vector3 point;

            item.IntersectBiRay(ray, out point);
            return point;
        }
    }
}