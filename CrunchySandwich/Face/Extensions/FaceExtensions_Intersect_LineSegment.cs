using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_Intersect_LineSegment
    {
        static public bool IsIntersecting(this Face item, LineSegment2 line_segment, out float distance, out Vector2 point)
        {
            if (item.IsIntersecting(line_segment.GetRay(), out distance, out point))
            {
                if (distance <= line_segment.GetLength())
                    return true;
            }

            return false;
        }

        static public bool IsIntersecting(this Face item, LineSegment2 line_segment, out float distance)
        {
            Vector2 point;

            return item.IsIntersecting(line_segment, out distance, out point);
        }

        static public bool IsIntersecting(this Face item, LineSegment2 line_segment, out Vector2 point)
        {
            float distance;

            return item.IsIntersecting(line_segment, out distance, out point);
        }
    }
}