using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Aspect
    {
        static public float GetFactorToFillDimension(this VectorF2 item, VectorF2 bounds)
        {
            return (bounds.x / item.x).Min(bounds.y / item.y);
        }

        static public VectorF2 GetFilledDimension(this VectorF2 item, VectorF2 bounds)
        {
            return item.GetFactorToFillDimension(bounds) * item;
        }
    }
}