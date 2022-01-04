using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_RectF2
    {
        static public RectF2 GetRectF2(this RectI2 item)
        {
            return RectF2Extensions.CreateLowerLeftRectF2(
                item.GetLowerLeftPoint().GetVectorF2(), 
                item.GetSize().GetVectorF2()
            );
        }
    }
}