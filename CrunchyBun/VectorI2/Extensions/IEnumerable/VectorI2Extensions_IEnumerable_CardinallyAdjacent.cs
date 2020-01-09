using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    using Bun;
    
    static public class VectorI2Extensions_IEnumerable_CardinallyAdjacent
    {
        static public IEnumerable<VectorI2> GetCardinallyAdjacent(this IEnumerable<VectorI2> item, VectorI2 point)
        {
            return item.Narrow(i => i.IsCardinallyAdjacent(point));
        }
        static public bool IsCardinallyAdjacent(this IEnumerable<VectorI2> item, VectorI2 point)
        {
            if (item.GetCardinallyAdjacent(point).IsNotEmpty())
                return true;

            return false;
        }

        static public IEnumerable<VectorI2> GetCardinallyAdjacentToAny(this IEnumerable<VectorI2> item, IEnumerable<VectorI2> points)
        {
            return item.Narrow(i => points.IsCardinallyAdjacent(i));
        }
        static public bool IsCardinallyAdjacentToAny(this IEnumerable<VectorI2> item, IEnumerable<VectorI2> points)
        {
            if (item.GetCardinallyAdjacentToAny(points).IsNotEmpty())
                return true;

            return false;
        }
    }
}