using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Line_Point
    {
        static public VectorF2 GetPointOnLineByPercent(this VectorF2 item, VectorF2 target, float percent)
        {
            return item * (1.0f - percent) + target * percent;
        }
        static public VectorF2 GetPointOnLine(this VectorF2 item, VectorF2 target, float distance)
        {
            return item.GetPointOnLineByPercent(target, distance / item.GetDistanceTo(target));
        }

        static public VectorF2 GetPointOnLineSegmentByPercent(this VectorF2 item, VectorF2 target, float percent)
        {
            return item.GetInterpolate(target, percent);
        }
        static public VectorF2 GetPointOnLineSegment(this VectorF2 item, VectorF2 target, float distance)
        {
            return item.GetPointOnLineSegmentByPercent(target, distance / item.GetDistanceTo(target));
        }

        static public VectorF2 GetPointNearLineByPercent(this VectorF2 item, VectorF2 target, float percent, float offset)
        {
            return item.GetPointOnLineByPercent(target, percent) + item.GetNormalizedNormal(target) * offset;
        }
        static public VectorF2 GetPointNearLine(this VectorF2 item, VectorF2 target, float distance, float offset)
        {
            return item.GetPointNearLineByPercent(target, distance / item.GetDistanceTo(target), offset);
        }
    }
}