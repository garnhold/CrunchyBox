using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Quantized
    {
        static public VectorF2 GetQuantizedMin(this VectorF2 item, float interval)
        {
            return item.GetQuantizedMin(new VectorF2(interval, interval));
        }
        static public VectorF2 GetQuantizedMin(this VectorF2 item, VectorF2 interval)
        {
            return new VectorF2(
                item.x.GetQuantizedMin(interval.x),
                item.y.GetQuantizedMin(interval.y)
            );
        }
    }
}