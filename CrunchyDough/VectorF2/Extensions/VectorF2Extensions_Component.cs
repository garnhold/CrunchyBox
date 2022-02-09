using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Component
    {
        static public VectorF2 GetComponentMultiply(this VectorF2 item, float x, float y)
        {
            return new VectorF2(item.x * x, item.y * y);
        }
        static public VectorF2 GetComponentMultiply(this VectorF2 item, VectorF2 other)
        {
            return item.GetComponentMultiply(other.x, other.y);
        }

        static public VectorF2 GetComponentDivide(this VectorF2 item, float x, float y)
        {
            return new VectorF2(item.x / x, item.y / y);
        }
        static public VectorF2 GetComponentDivide(this VectorF2 item, VectorF2 other)
        {
            return item.GetComponentDivide(other.x, other.y);
        }

        static public float GetComponentsMax(this VectorF2 item)
        {
            return item.x.Max(item.y);
        }
        static public float GetComponentsMin(this VectorF2 item)
        {
            return item.x.Min(item.y);
        }

        static public float GetComponentsSum(this VectorF2 item)
        {
            return item.x + item.y;
        }
        static public float GetComponentsProduct(this VectorF2 item)
        {
            return item.x * item.y;
        }

        static public float GetComponentsMagnitudeMax(this VectorF2 item)
        {
            if (item.x.GetAbs() > item.y.GetAbs())
                return item.x;

            return item.y;
        }
        static public float GetComponentsMagnitudeMin(this VectorF2 item)
        {
            if (item.x.GetAbs() < item.y.GetAbs())
                return item.x;

            return item.y;
        }
    }
}