using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorI2Extensions_IEnumerable_ints
    {
        static public IEnumerable<int> ConvertToInts(this IEnumerable<VectorI2> item)
        {
            foreach (VectorI2 vector in item)
            {
                yield return vector.x;
                yield return vector.y;
            }
        }

        static public IEnumerable<VectorI2> ConvertToVectorI2s(this IEnumerable<int> item, IEnumerable<int> other)
        {
            return item.PairStrict(other, (x, y) => new VectorI2(x, y));
        }
    }
}