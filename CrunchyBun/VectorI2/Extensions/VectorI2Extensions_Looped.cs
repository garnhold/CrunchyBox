using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorI2Extensions_Looped
    {
        static public VectorI2 GetLooped(this VectorI2 item, int length)
        {
            return new VectorI2(item.x.GetLooped(length), item.y.GetLooped(length));
        }

        static public VectorI2 GetLooped(this VectorI2 item, VectorI2 length)
        {
            return new VectorI2(item.x.GetLooped(length.x), item.y.GetLooped(length.y));
        }
    }
}