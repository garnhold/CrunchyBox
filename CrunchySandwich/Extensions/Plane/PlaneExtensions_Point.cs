using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Point
    {
        static public Vector3 ProjectPoint(this Plane item, Vector3 point)
        {
            return point - item.normal * item.GetSignedDistanceToPoint(point);
        }

        static public float GetSignedDistanceToPoint(this Plane item, Vector3 point)
        {
            return item.normal.GetDot(point - item.GetOrigin());
        }

        static public float GetAbsoluteDistanceToPoint(this Plane item, Vector3 point)
        {
            return item.GetSignedDistanceToPoint(point).GetAbs();
        }

        static public bool IsCoplanar(this Plane item, Vector3 point, float tolerance = 0.0f)
        {
            if (item.GetAbsoluteDistanceToPoint(point) <= tolerance)
                return true;

            return false;
        }

        static public bool AreCoplanar(this Plane item, IEnumerable<Vector3> points, float tolerance = 0.0f)
        {
            if (points.AreAll(p => item.IsCoplanar(p, tolerance)))
                return true;

            return false;
        }
    }
}