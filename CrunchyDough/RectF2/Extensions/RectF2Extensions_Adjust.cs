using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_Adjust
    {
        static public RectF2 GetAdjusted(this RectF2 item, VectorF2 min_adjust, VectorF2 max_adjust)
        {
            return new RectF2(item.min + min_adjust, item.max + max_adjust);
        }

        static public RectF2 GetEnlarged(this RectF2 item, VectorF2 min_adjust, VectorF2 max_adjust)
        {
            return item.GetAdjusted(-min_adjust, max_adjust);
        }
        static public RectF2 GetEnlarged(this RectF2 item, float x, float y)
        {
            return item.GetEnlarged(new VectorF2(x, y), new VectorF2(x, y));
        }
        static public RectF2 GetEnlarged(this RectF2 item, VectorF2 amount)
        {
            return item.GetEnlarged(amount.x, amount.y);
        }
        static public RectF2 GetEnlarged(this RectF2 item, float amount)
        {
            return item.GetEnlarged(amount, amount);
        }

        static public RectF2 GetShrunk(this RectF2 item, VectorF2 min_adjust, VectorF2 max_adjust)
        {
            return item.GetEnlarged(-min_adjust, -max_adjust);
        }
        static public RectF2 GetShrunk(this RectF2 item, float x, float y)
        {
            return item.GetShrunk(new VectorF2(x, y), new VectorF2(x, y));
        }
        static public RectF2 GetShrunk(this RectF2 item, VectorF2 amount)
        {
            return item.GetShrunk(amount.x, amount.y);
        }
        static public RectF2 GetShrunk(this RectF2 item, float amount)
        {
            return item.GetShrunk(amount, amount);
        }
    }
}