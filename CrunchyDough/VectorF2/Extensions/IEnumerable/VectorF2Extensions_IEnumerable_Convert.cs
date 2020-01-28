using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_IEnumerable_Convert
    {
        static public IEnumerable<J> ConvertLoop<J>(this IEnumerable<VectorF2> item, Operation<J, VectorF2, VectorF2> operation)
        {
            return item.WindClockwise().OpenLoop().ConvertLoopedNeighbors((v1, v2, v3) => operation(v2, v2.GetNormalizedNormal(v1, v3)));
        }
    }
}