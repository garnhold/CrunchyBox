using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Magnitude
    {
        static public float GetMagnitude(this VectorF2 item)
        {
            return Mathq.Sqrt(item.GetSquaredMagnitude());
        }

        static public float GetSquaredMagnitude(this VectorF2 item)
        {
            return item.x.GetSquared() + item.y.GetSquared();
        }
    }
}