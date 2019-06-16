using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_Intersect_Ray
    {
        static public bool IsIntersecting(this Face item, Ray2 ray, out float distance, out Vector2 point)
        {
            if (item.IsIntersectingLine(ray, out distance, out point) && distance >= 0.0f)
                return true;

            distance = float.MaxValue;
            return false;
        }

        static public bool IsIntersecting(this Face item, Ray2 ray, out float distance)
        {
            Vector2 point;

            return item.IsIntersecting(ray, out distance, out point);
        }

        static public bool IsIntersecting(this Face item, Ray2 ray, out Vector2 point)
        {
            float distance;

            return item.IsIntersecting(ray, out distance, out point);
        }
    }
}