using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class VectorI2Extensions_Magnitude
    {
        static public float GetMagnitude(this VectorI2 item)
        {
            return Mathq.Sqrt(item.GetSquaredMagnitude());
        }

        static public int GetSquaredMagnitude(this VectorI2 item)
        {
            return item.x.GetSquared() + item.y.GetSquared();
        }
    }
}