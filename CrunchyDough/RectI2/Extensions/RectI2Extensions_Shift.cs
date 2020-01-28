using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Shift
    {
        static public RectI2 GetShifted(this RectI2 item, VectorI2 amount)
        {
            return item.GetAdjusted(amount, amount);
        }

        static public RectI2 GetHorizontallyShifted(this RectI2 item, int amount)
        {
            return item.GetShifted(new VectorI2(amount, 0));
        }

        static public RectI2 GetVerticallyShifted(this RectI2 item, int amount)
        {
            return item.GetShifted(new VectorI2(0, amount));
        }
    }
}