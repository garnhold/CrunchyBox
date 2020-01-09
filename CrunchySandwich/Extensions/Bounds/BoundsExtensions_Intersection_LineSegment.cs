using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class BoundsExtensions_Intersection_LineSegment
    {
        static public bool IsIntersecting(this Bounds item, LineSegment3 line_segment, out float distance)
        {
            if (item.IntersectRay(line_segment.GetRay(), out distance))
            {
                if (distance <= line_segment.GetLength())
                    return true;
            }

            return false;
        }

        static public bool IsIntersecting(this Bounds item, LineSegment3 line_segment, out Vector3 point)
        {
            float distance;

            if (item.IsIntersecting(line_segment, out distance))
            {
                point = line_segment.GetPointOnByDistance(distance);
                return true;
            }

            point = Vector3.zero;
            return false;
        }
    }
}