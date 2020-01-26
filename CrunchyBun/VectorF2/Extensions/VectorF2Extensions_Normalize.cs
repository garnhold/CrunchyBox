using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions_Normalize
    {
        static public VectorF2 GetNormalized(this VectorF2 item)
        {
            return item / item.GetMagnitude();
        }

        static public VectorF2 GetNormalized(this VectorF2 item, out float magnitude)
        {
            magnitude = item.GetMagnitude();

            if(magnitude != 0.0f)
                return item / magnitude;

            return VectorF2.ZERO;
        }
    }
}