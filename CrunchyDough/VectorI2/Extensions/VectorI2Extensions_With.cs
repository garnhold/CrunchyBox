using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class VectorI2Extensions_With
    {
        static public VectorI2 GetWithX(this VectorI2 item, int x)
        {
            return new VectorI2(x, item.y);
        }

        static public VectorI2 GetWithY(this VectorI2 item, int y)
        {
            return new VectorI2(item.x, y);
        }
    }
}