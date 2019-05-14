using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Plane2Extensions_Side
    {
        static public bool IsOutside(this Plane2 item, Vector2 point, float tolerance = 0.0f)
        {
            if(item.GetSignedDistanceToPoint(point) > tolerance)
                return true;

            return false;
        }

        static public bool IsInside(this Plane2 item, Vector3 point, float tolerance = 0.0f)
        {
            if (item.IsOutside(point, tolerance) == false)
                return true;

            return false;
        }
    }
}