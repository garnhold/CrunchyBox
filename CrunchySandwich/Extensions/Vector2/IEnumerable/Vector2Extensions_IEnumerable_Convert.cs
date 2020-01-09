using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_IEnumerable_Convert
    {
        static public IEnumerable<J> ConvertLoop<J>(this IEnumerable<Vector2> item, Operation<J, Vector2, Vector2> operation)
        {
            return item.WindClockwise().OpenLoop().ConvertLoopedNeighbors((v1, v2, v3) => operation(v2, v2.GetNormalizedNormal(v1, v3)));
        }
    }
}