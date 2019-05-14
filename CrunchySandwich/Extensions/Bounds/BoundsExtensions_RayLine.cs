using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class BoundsExtensions_RayLine
    {
        static public bool IntersectRayLine(this Bounds item, RayLine ray_line, out float distance)
        {
            if (item.IntersectRay(ray_line.GetRay(), out distance))
            {
                if (distance <= ray_line.GetLength())
                    return true;
            }

            return false;
        }

        static public bool IntersectRayLine(this Bounds item, RayLine ray_line, out Vector3 point)
        {
            float distance;

            if (item.IntersectRayLine(ray_line, out distance))
            {
                point = ray_line.GetPointAlong(distance);
                return true;
            }

            point = Vector3.zero;
            return false;
        }
    }
}