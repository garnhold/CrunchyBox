using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_IEnumerable_Winding
    {
        static public IEnumerable<VectorF2> WindClockwise(this IEnumerable<VectorF2> item)
        {
            if (item.IsLoopClockwise())
                return item;

            return item.Reverse();
        }
        static public IEnumerable<VectorF2> WindCounterClockwise(this IEnumerable<VectorF2> item)
        {
            if (item.IsLoopCounterClockwise())
                return item;

            return item.Reverse();
        }
    }
}