using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Plane2Extensions_Intersect_Triangle
    {
        static public bool IsIntersecting(this Plane2 item, Triangle2 triangle, out LineSegment2 output)
        {
            Vector2 v0;
            Vector2 v1;

            if (triangle.GetEdges()
                .TryConvert((LineSegment2 e, out Vector2 v) => item.IsIntersecting(e, out v))
                .PartOut(out v0, out v1) == 2)
            {
                output = new LineSegment2(v0, v1);
                return true;
            }

            output = default(LineSegment2);
            return false;
        }
    }
}