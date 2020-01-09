using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Triangle
    {
        static public bool FullyContains(this Plane item, Triangle3 triangle)
        {
            if(
                item.IsInside(triangle.v0) &&
                item.IsInside(triangle.v1) &&
                item.IsInside(triangle.v2)
            )
            {
                return true;
            }

            return false;
        }

        static public bool TryGetTriangleCoplanarEdge(this Plane item, Triangle3 triangle, float tolerance, out LineSegment3 edge)
        {
            bool is_v0_near = item.GetAbsoluteDistanceToPoint(triangle.v0) <= tolerance;
            bool is_v1_near = item.GetAbsoluteDistanceToPoint(triangle.v1) <= tolerance;
            bool is_v2_near = item.GetAbsoluteDistanceToPoint(triangle.v2) <= tolerance;

            if (is_v0_near && is_v1_near && is_v2_near == false)
            {
                edge = triangle.GetEdge01();
                return true;
            }

            if (is_v1_near && is_v2_near && is_v0_near == false)
            {
                edge = triangle.GetEdge12();
                return true;
            }

            if (is_v2_near && is_v0_near && is_v1_near == false)
            {
                edge = triangle.GetEdge20();
                return true;
            }

            edge = default(LineSegment3);
            return false;
        }
    }
}