using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_Side
    {
        static public bool IsOutside(this Plane item, Vector3 point, float tolerance = 0.0f)
        {
            if (item.GetSignedDistanceToPoint(point) > tolerance)
                return true;

            return false;
        }

        static public bool IsInside(this Plane item, Vector3 point, float tolerance = 0.0f)
        {
            if (item.IsOutside(point, tolerance) == false)
                return true;

            return false;
        }
    }
}