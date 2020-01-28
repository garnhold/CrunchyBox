using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_IEnumerable_LoopInflate
    {
        static public IEnumerable<VectorF2> InflateLoop(this IEnumerable<VectorF2> item, float amount)
        {
            return item.ConvertLoop((p, n) => p + n * amount);
        }
    }
}