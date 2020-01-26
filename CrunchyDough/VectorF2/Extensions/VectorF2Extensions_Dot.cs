using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Dot
    {
        static public float GetDot(this VectorF2 item, VectorF2 other)
        {
            return item.x * other.x + item.y * other.y;
        }
    }
}