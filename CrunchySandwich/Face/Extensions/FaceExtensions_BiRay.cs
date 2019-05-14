using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_BiRay
    {
        static public bool IntersectsBiRay(this Face item, Ray2 ray, out float distance, out Vector2 point)
        {
            bool did_intersect = ray.IntersectsGeneralBi(item.v0, item.normal, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect && point.IsBoundBetween(item.v0, item.v1);
        }

        static public bool IntersectsBiRay(this Face item, Ray2 ray, out float distance)
        {
            Vector2 point;

            return item.IntersectsBiRay(ray, out distance, out point);
        }

        static public bool IntersectsBiRay(this Face item, Ray2 ray, out Vector2 point)
        {
            float distance;

            return item.IntersectsBiRay(ray, out distance, out point);
        }
    }
}