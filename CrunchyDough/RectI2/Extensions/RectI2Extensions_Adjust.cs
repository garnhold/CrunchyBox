using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Adjust
    {
        static public RectI2 GetAdjusted(this RectI2 item, VectorI2 min_adjust, VectorI2 max_adjust)
        {
            return new RectI2(item.min + min_adjust, item.max + max_adjust);
        }

        static public RectI2 GetEnlarged(this RectI2 item, VectorI2 min_adjust, VectorI2 max_adjust)
        {
            return item.GetAdjusted(-min_adjust, max_adjust);
        }
        static public RectI2 GetEnlarged(this RectI2 item, int x, int y)
        {
            return item.GetEnlarged(new VectorI2(x, y), new VectorI2(x, y));
        }
        static public RectI2 GetEnlarged(this RectI2 item, VectorI2 amount)
        {
            return item.GetEnlarged(amount.x, amount.y);
        }
        static public RectI2 GetEnlarged(this RectI2 item, int amount)
        {
            return item.GetEnlarged(amount, amount);
        }

        static public RectI2 GetShrunk(this RectI2 item, VectorI2 min_adjust, VectorI2 max_adjust)
        {
            return item.GetEnlarged(-min_adjust, -max_adjust);
        }
        static public RectI2 GetShrunk(this RectI2 item, int x, int y)
        {
            return item.GetShrunk(new VectorI2(x, y), new VectorI2(x, y));
        }
        static public RectI2 GetShrunk(this RectI2 item, VectorI2 amount)
        {
            return item.GetShrunk(amount.x, amount.y);
        }
        static public RectI2 GetShrunk(this RectI2 item, int amount)
        {
            return item.GetShrunk(amount, amount);
        }
    }
}