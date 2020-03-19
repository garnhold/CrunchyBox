using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorF2Extensions_IEnumerable_Floats
    {
        static public IEnumerable<float> ConvertToFloats(this IEnumerable<VectorF2> item)
        {
            foreach (VectorF2 vector in item)
            {
                yield return vector.x;
                yield return vector.y;
            }
        }

        static public IEnumerable<VectorF2> ConvertToVectorF2s(this IEnumerable<float> item, IEnumerable<float> other)
        {
            return item.PairStrict(other, (x, y) => new VectorF2(x, y));
        }
    }
}