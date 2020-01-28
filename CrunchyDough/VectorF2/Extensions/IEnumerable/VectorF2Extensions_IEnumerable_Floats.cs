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
    }
}