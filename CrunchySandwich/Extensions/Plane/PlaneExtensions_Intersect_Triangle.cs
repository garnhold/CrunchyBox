using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Intersect_Triangle
    {
        static public bool IsIntersecting(this Plane item, Triangle3 triangle, out LineSegment3 output)
        {
            Vector3 v0;
            Vector3 v1;

            if (triangle.GetEdges()
                .TryConvert((LineSegment3 e, out Vector3 v) => item.IsIntersecting(e, out v))
                .PartOut(out v0, out v1) == 2)
            {
                output = new LineSegment3(v0, v1);
                return true;
            }

            output = default(LineSegment3);
            return false;
        }
    }
}