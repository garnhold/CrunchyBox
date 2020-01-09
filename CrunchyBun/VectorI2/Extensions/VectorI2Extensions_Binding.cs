using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    using Bun;
    
    static public class VectorI2Extensions_Binding
    {
        static public VectorI2 BindAbove(this VectorI2 item, VectorI2 lower)
        {
            return new VectorI2(item.x.BindAbove(lower.x), item.y.BindAbove(lower.y));
        }

        static public VectorI2 BindBelow(this VectorI2 item, VectorI2 upper)
        {
            return new VectorI2(item.x.BindBelow(upper.x), item.y.BindBelow(upper.y));
        }

        static public VectorI2 BindBetween(this VectorI2 item, VectorI2 value1, VectorI2 value2)
        {
            return new VectorI2(item.x.BindBetween(value1.x, value2.x), item.y.BindBetween(value1.y, value2.y));
        }
    }
}