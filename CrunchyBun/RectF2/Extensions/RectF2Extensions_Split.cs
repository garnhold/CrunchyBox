using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class RectF2Extensions_Split
    {
        static public void SplitByX(this RectF2 item, float x, out RectF2 left, out RectF2 right)
        {
            float split = x.Min(item.GetRight());

            left = RectF2Extensions.CreateStrictMinMaxRectF2(item.min, item.max.GetWithX(split));
            right = RectF2Extensions.CreateStrictMinMaxRectF2(item.min.GetWithX(split), item.max);
        }
        static public void SplitByXLeftOffset(this RectF2 item, float x_offset, out RectF2 left, out RectF2 right)
        {
            item.SplitByX(item.GetLeft() + x_offset, out left, out right);
        }
        static public void SplitByXRightOffset(this RectF2 item, float x_offset, out RectF2 left, out RectF2 right)
        {
            item.SplitByX(item.GetRight() - x_offset, out left, out right);
        }

        static public void SplitByY(this RectF2 item, float y, out RectF2 bottom, out RectF2 top)
        {
            float split = y.Min(item.GetTop());

            bottom = RectF2Extensions.CreateStrictMinMaxRectF2(item.min, item.max.GetWithY(split));
            top = RectF2Extensions.CreateStrictMinMaxRectF2(item.min.GetWithY(split), item.max);
            
        }
        static public void SplitByYBottomOffset(this RectF2 item, float y_offset, out RectF2 bottom, out RectF2 top)
        {
            item.SplitByY(item.GetBottom() + y_offset, out bottom, out top);
        }
        static public void SplitByYTopOffset(this RectF2 item, float y_offset, out RectF2 bottom, out RectF2 top)
        {
            item.SplitByY(item.GetTop() - y_offset, out bottom, out top);
        }
    }
}