using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorI2Extensions_Radiating
    {
        static public IEnumerable<VectorI2> GetRadiating(this VectorI2 item, int radius)
        {
            return RadiatingWalker.Iterator(radius).Convert(d => item + d);
        }
    }
}