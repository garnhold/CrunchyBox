using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_RayLine
    {
        static public bool IntersectRayLine(this Plane item, RayLine ray_line, out float distance)
        {
            if (item.IntersectRay(ray_line.GetRay(), out distance))
            {
                if (distance <= ray_line.GetLength())
                    return true;
            }

            return false;
        }

        static public bool IntersectRayLine(this Plane item, RayLine ray_line, out Vector3 point)
        {
            float distance;
            bool did_intersect = item.IntersectRayLine(ray_line, out distance);

            point = ray_line.GetPointAlong(distance);
            return did_intersect;
        }
    }
}