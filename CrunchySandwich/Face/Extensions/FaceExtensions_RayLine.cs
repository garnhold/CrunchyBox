using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_RayLine
    {
        static public bool IntersectsRayLine(this Face item, RayLine2 ray_line, out float distance, out Vector2 point)
        {
            if (item.IntersectsRay(ray_line.GetRay(), out distance, out point))
            {
                if (distance <= ray_line.GetLength())
                    return true;
            }

            return false;
        }

        static public bool IntersectsRayLine(this Face item, RayLine2 ray_line, out float distance)
        {
            Vector2 point;

            return item.IntersectsRayLine(ray_line, out distance, out point);
        }

        static public bool IntersectsRayLine(this Face item, RayLine2 ray_line, out Vector2 point)
        {
            float distance;

            return item.IntersectsRayLine(ray_line, out distance, out point);
        }

        static public RayLine2 GetFaceRayLine(this Face item)
        {
            return new RayLine2(item.v0, item.v1);
        }
    }
}