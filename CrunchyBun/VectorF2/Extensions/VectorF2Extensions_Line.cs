using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Line
    {
        static public VectorF2 GetNormal(this VectorF2 item)
        {
            return new VectorF2(-item.y, item.x);
        }
        static public VectorF2 GetNormal(this VectorF2 item, VectorF2 point)
        {
            return (point - item).GetNormal();
        }

        static public VectorF2 GetNormalizedNormal(this VectorF2 item)
        {
            return item.GetNormal().GetNormalized();
        }
        static public VectorF2 GetNormalizedNormal(this VectorF2 item, VectorF2 point)
        {
            return (point - item).GetNormalizedNormal();
        }

        static public float GetDistanceToLine(this VectorF2 item, VectorF2 point1, VectorF2 point2)
        {
            return point1.GetNormalizedNormal(point2).GetDot(item - point1).GetAbs();
        }
    }
}