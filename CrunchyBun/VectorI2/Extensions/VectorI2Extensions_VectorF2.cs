using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    using Bun;
    
    static public class VectorI2Extensions_VectorF2
    {
        static public VectorF2 GetVectorF2(this VectorI2 item)
        {
            return new VectorF2(item.x, item.y);
        }

        static public VectorF2 GetCenterVectorF2(this VectorI2 item)
        {
            return new VectorF2(item.x + 0.5f, item.y + 0.5f);
        }

        static public VectorF2 GetInflated(this VectorI2 item, VectorF2 unit)
        {
            return item.GetVectorF2().GetComponentMultiply(unit);
        }

        static public VectorF2 GetCenterInflated(this VectorI2 item, VectorF2 unit)
        {
            return item.GetCenterVectorF2().GetComponentMultiply(unit);
        }
    }
}