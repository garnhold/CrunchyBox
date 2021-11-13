using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorI2Extensions_Component
    {
        static public VectorI2 GetComponentMultiply(this VectorI2 item, int x, int y)
        {
            return new VectorI2(item.x * x, item.y * y);
        }
        static public VectorI2 GetComponentMultiply(this VectorI2 item, VectorI2 other)
        {
            return item.GetComponentMultiply(other.x, other.y);
        }

        static public VectorI2 GetComponentDivide(this VectorI2 item, int x, int y)
        {
            return new VectorI2(item.x / x, item.y / y);
        }
        static public VectorI2 GetComponentDivide(this VectorI2 item, VectorI2 other)
        {
            return item.GetComponentDivide(other.x, other.y);
        }

        static public int GetMaxComponent(this VectorI2 item)
        {
            return item.x.Max(item.y);
        }

        static public int GetMinComponent(this VectorI2 item)
        {
            return item.x.Min(item.y);
        }

        static public float GetMagnitudeMaxComponent(this VectorI2 item)
        {
            if (item.x.GetAbs() > item.y.GetAbs())
                return item.x;

            return item.y;
        }
        static public float GetMagnitudeMinComponent(this VectorI2 item)
        {
            if (item.x.GetAbs() < item.y.GetAbs())
                return item.x;

            return item.y;
        }
    }
}