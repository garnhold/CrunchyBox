using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Line
    {
        static public float GetDistanceToLine(this Vector2 item, Vector2 point1, Vector2 point2)
        {
            return point1.GetNormalizedNormal(point2).GetDot(item - point1).GetAbs();
        }
    }
}