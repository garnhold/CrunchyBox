using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorI2Extensions_Neighbors
    {
        static public IEnumerable<VectorI2> GetCardinalNeighbors(this VectorI2 item)
        {
            yield return new VectorI2(item.x, item.y - 1);
            yield return new VectorI2(item.x - 1, item.y);
            yield return new VectorI2(item.x + 1, item.y);
            yield return new VectorI2(item.x, item.y + 1);
        }

        static public IEnumerable<VectorI2> GetOrdinalNeighbors(this VectorI2 item)
        {
            yield return new VectorI2(item.x - 1, item.y - 1);
            yield return new VectorI2(item.x + 1, item.y - 1);
            yield return new VectorI2(item.x - 1, item.y + 1);
            yield return new VectorI2(item.x + 1, item.y + 1);
        }

        static public IEnumerable<VectorI2> GetCardinalThenOrdinalNeighbors(this VectorI2 item)
        {
            return item.GetCardinalNeighbors().Append(item.GetOrdinalNeighbors());
        }
        static public IEnumerable<VectorI2> GetNeighbors(this VectorI2 item)
        {
            return item.GetCardinalThenOrdinalNeighbors();
        }
    }
}