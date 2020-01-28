using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_RectF2
    {
        static public RectF2 GetRect(this VectorF2 item)
        {
            return RectF2Extensions.CreateCenterRectF2(item, VectorF2.ZERO);
        }
    }
}