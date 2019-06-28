using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Line
    {
        static public float GetDistanceToLine(this VectorF2 item, VectorF2 point1, VectorF2 point2)
        {
            return point1.GetNormalizedNormal(point2).GetDot(item - point1).GetAbs();
        }
    }
}