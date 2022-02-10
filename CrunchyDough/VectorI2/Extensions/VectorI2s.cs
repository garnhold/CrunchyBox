using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorI2s
    {
        static public IEnumerable<VectorI2> POTDimensionSequence(int max_power)
        {
            int x = 1;
            int y = 1;

            yield return new VectorI2(x, y);

            for (int i = 0; i < max_power; i++)
            {
                x *= 2;
                yield return new VectorI2(x, y);

                y *= 2;
                yield return new VectorI2(x, y);
            }
        }
    }
}