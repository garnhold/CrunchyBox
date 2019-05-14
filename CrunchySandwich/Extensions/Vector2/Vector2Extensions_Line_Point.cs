using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Line_Point
    {
        static public Vector2 GetPointOnLineByPercent(this Vector2 item, Vector2 target, float percent)
        {
            return item * (1.0f - percent) + target * percent;
        }
        static public Vector2 GetPointOnLine(this Vector2 item, Vector2 target, float distance)
        {
            return item.GetPointOnLineByPercent(target, distance / item.GetDistanceTo(target));
        }

        static public Vector2 GetPointOnLineSegmentByPercent(this Vector2 item, Vector2 target, float percent)
        {
            return item.GetInterpolate(target, percent);
        }
        static public Vector2 GetPointOnLineSegment(this Vector2 item, Vector2 target, float distance)
        {
            return item.GetPointOnLineSegmentByPercent(target, distance / item.GetDistanceTo(target));
        }

        static public Vector2 GetPointNearLineByPercent(this Vector2 item, Vector2 target, float percent, float offset)
        {
            return item.GetPointOnLineByPercent(target, percent) + item.GetNormalizedNormal(target) * offset;
        }
        static public Vector2 GetPointNearLine(this Vector2 item, Vector2 target, float distance, float offset)
        {
            return item.GetPointNearLineByPercent(target, distance / item.GetDistanceTo(target), offset);
        }
    }
}