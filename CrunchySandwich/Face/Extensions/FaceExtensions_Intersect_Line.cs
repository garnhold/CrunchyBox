using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_Intersect_Line
    {
        static public bool IsIntersectingLine(this Face item, Ray2 ray, out float distance, out Vector2 point)
        {
            bool did_intersect = ray.IsIntersectingLine(item.v0, item.normal, out distance);

            point = ray.GetPointAlong(distance);
            return did_intersect && point.IsBoundBetween(item.v0, item.v1);
        }

        static public bool IsIntersectingLine(this Face item, Ray2 ray, out float distance)
        {
            Vector2 point;

            return item.IsIntersectingLine(ray, out distance, out point);
        }

        static public bool IsIntersectingLine(this Face item, Ray2 ray, out Vector2 point)
        {
            float distance;

            return item.IsIntersectingLine(ray, out distance, out point);
        }
    }
}