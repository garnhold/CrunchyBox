using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_Line_Point
    {
        static public Vector3 GetPointOnLineByPercent(this Vector3 item, Vector3 target, float percent)
        {
            return item * (1.0f - percent) + target * percent;
        }
        static public Vector3 GetPointOnLine(this Vector3 item, Vector3 target, float distance)
        {
            return item.GetPointOnLineByPercent(target, distance / item.GetDistanceTo(target));
        }

        static public Vector3 GetPointOnLineSegmentByPercent(this Vector3 item, Vector3 target, float percent)
        {
            return item.GetInterpolate(target, percent);
        }
        static public Vector3 GetPointOnLineSegment(this Vector3 item, Vector3 target, float distance)
        {
            return item.GetPointOnLineSegmentByPercent(target, distance / item.GetDistanceTo(target));
        }
    }
}