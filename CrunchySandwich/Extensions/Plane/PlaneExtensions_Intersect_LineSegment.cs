using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Intersect_LineSegment
    {
        static public bool IsIntersecting(this Plane item, LineSegment3 line_segment, out float distance)
        {
            if (item.IsIntersecting(line_segment.GetRay(), out distance))
            {
                if (distance <= line_segment.GetLength())
                    return true;
            }

            return false;
        }

        static public bool IsIntersecting(this Plane item, LineSegment3 line_segment, out Vector3 point)
        {
            float distance;
            bool did_intersect = item.IsIntersecting(line_segment, out distance);

            point = line_segment.GetPointOnByDistance(distance);
            return did_intersect;
        }

        static public bool IsCoplanar(this Plane item, LineSegment3 line_segment, float tolerance = 0.0f)
        {
            if (item.AreCoplanar(line_segment.GetPoints(), tolerance))
                return true;

            return false;
        }
    }
}