using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_VectorI2
    {
        static public VectorI2 GetVectorI2(this VectorF2 item)
        {
            return new VectorI2(item.x, item.y);
        }

        static public VectorI2 GetDeflated(this VectorF2 item, VectorF2 unit)
        {
            return item.GetComponentDivide(unit).GetVectorI2();
        }
        static public VectorI2 GetDeflated(this VectorF2 item, float unit)
        {
            return item.GetDeflated(new VectorF2(unit, unit));
        }
    }
}