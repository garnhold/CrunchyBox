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

        static public float GetMaxComponent(this VectorF2 item)
        {
            return item.x.Max(item.y);
        }

        static public float GetMinComponent(this VectorF2 item)
        {
            return item.x.Min(item.y);
        }
    }
}