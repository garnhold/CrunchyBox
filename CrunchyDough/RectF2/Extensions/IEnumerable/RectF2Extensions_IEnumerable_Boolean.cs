using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_IEnumerable_Boolean
    {
        static public RectF2 GetEncompassing(this IEnumerable<RectF2> item)
        {
            return item.PerformIteratedBinaryOperation((r1, r2) => r1.GetEncompassing(r2));
        }
    }
}