using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorI2Extensions_Abs
    {
        static public VectorI2 GetAbs(this VectorI2 item)
        {
            return new VectorI2(item.x.GetAbs(), item.y.GetAbs());
        }
    }
}