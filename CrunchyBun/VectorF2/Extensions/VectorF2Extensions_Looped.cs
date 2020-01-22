using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions_Looped
    {
        static public VectorF2 GetLooped(this VectorF2 item, float length)
        {
            return new VectorF2(item.x.GetLooped(length), item.y.GetLooped(length));
        }

        static public VectorF2 GetLooped(this VectorF2 item, VectorF2 length)
        {
            return new VectorF2(item.x.GetLooped(length.x), item.y.GetLooped(length.y));
        }
    }
}