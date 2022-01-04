using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_RectI2
    {
        static public RectI2 GetRectI2(this RectF2 item)
        {
            return RectI2Extensions.CreateLowerLeftRectI2(
                item.GetLowerLeftPoint().GetVectorI2(), 
                item.GetSize().GetVectorI2()
            );
        }
    }
}