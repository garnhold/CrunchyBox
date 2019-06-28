using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Invert
    {
        static public VectorF2 GetInvertX(this VectorF2 item)
        {
            return new VectorF2(-item.x, item.y);
        }

        static public VectorF2 GetInvertY(this VectorF2 item)
        {
            return new VectorF2(item.x, -item.y);
        }
    }
}