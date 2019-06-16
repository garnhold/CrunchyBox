using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Plane2Extensions_Intersect_LineSegment
    {
        static public bool IsIntersecting(this Plane2 item, LineSegment2 line_segment, out float distance)
        {
            if (item.IsIntersecting(line_segment.GetRay(), out distance))
            {
                if (distance <= line_segment.GetLength())
                    return true;
            }

            return false;
        }

        static public bool IsIntersecting(this Plane2 item, LineSegment2 line_segment, out Vector2 point)
        {
            float distance;
            bool did_intersect = item.IsIntersecting(line_segment, out distance);

            point = line_segment.GetPointOnByDistance(distance);
            return did_intersect;
        }
    }
}