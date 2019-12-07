using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class RectF2Extensions_Shift
    {
        static public RectF2 GetShifted(this RectF2 item, VectorF2 amount)
        {
            return item.GetAdjusted(amount, amount);
        }

        static public RectF2 GetHorizontallyShifted(this RectF2 item, float amount)
        {
            return item.GetShifted(new VectorF2(amount, 0.0f));
        }

        static public RectF2 GetVerticallyShifted(this RectF2 item, float amount)
        {
            return item.GetShifted(new VectorF2(0.0f, amount));
        }
    }
}