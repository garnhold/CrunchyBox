using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Abs
    {
        static public VectorF2 GetAbs(this VectorF2 item)
        {
            return new VectorF2(item.x.GetAbs(), item.y.GetAbs());
        }
    }
}