using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_Ray
    {
        static public bool IntersectsRay(this Face item, Ray2 ray, out float distance, out Vector2 point)
        {
            if (item.IntersectsBiRay(ray, out distance, out point) && distance >= 0.0f)
                return true;

            distance = float.MaxValue;
            return false;
        }

        static public bool IntersectsRay(this Face item, Ray2 ray, out float distance)
        {
            Vector2 point;

            return item.IntersectsRay(ray, out distance, out point);
        }

        static public bool IntersectsRay(this Face item, Ray2 ray, out Vector2 point)
        {
            float distance;

            return item.IntersectsRay(ray, out distance, out point);
        }
    }
}