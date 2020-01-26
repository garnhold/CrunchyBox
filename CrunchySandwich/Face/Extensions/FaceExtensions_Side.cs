using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class FaceExtensions_Side
    {
        static public bool IsOutside(this Face item, Vector2 point, float tolerance = 0.0f)
        {
            if (item.normal.GetDot(point - item.v0) > tolerance)
                return true;

            return false;
        }

        static public bool IsInside(this Face item, Vector2 point, float tolerance = 0.0f)
        {
            if(item.IsOutside(point, tolerance) == false)
                return true;

            return false;
        }

        static public bool IsComplyingVector(this Face item, Vector2 vector)
        {
            if (item.normal.IsComplyingDirection(vector))
                return true;

            return false;
        }

        static public bool IsOpposingVector(this Face item, Vector2 vector)
        {
            if (item.normal.IsOpposingDirection(vector))
                return true;

            return false;
        }
    }
}