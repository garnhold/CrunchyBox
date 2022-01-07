using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorF2Extensions_Precision
    {
        static public VectorF2 GetAtPrecision(this VectorF2 item, int exponent)
        {
            return new VectorF2(
                item.x.GetAtPrecision(exponent),
                item.y.GetAtPrecision(exponent)
            );
        }
    }
}