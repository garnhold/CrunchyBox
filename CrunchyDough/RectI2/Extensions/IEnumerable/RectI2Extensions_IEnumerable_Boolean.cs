using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_IEnumerable_Boolean
    {
        static public RectI2 GetEncompassing(this IEnumerable<RectI2> item)
        {
            return item.PerformIteratedBinaryOperation((r1, r2) => r1.GetEncompassing(r2));
        }
    }
}