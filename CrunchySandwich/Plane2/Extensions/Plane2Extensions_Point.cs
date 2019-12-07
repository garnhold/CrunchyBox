using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Plane2Extensions_Point
    {
        static public Vector2 ProjectPoint(this Plane2 item, Vector2 point)
        {
            return point - item.normal * item.GetSignedDistanceToPoint(point);
        }

        static public float GetSignedDistanceToPoint(this Plane2 item, Vector2 point)
        {
            return item.normal.GetDot(point - item.GetOrigin());
        }

        static public float GetAbsoluteDistanceToPoint(this Plane2 item, Vector2 point)
        {
            return item.GetSignedDistanceToPoint(point).GetAbs();
        }
    }
}