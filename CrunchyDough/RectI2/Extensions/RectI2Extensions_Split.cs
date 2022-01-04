using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Split
    {
        static public void SplitByX(this RectI2 item, int x, out RectI2 left, out RectI2 right)
        {
            int split = x.Min(item.GetRight());

            left = RectI2Extensions.CreateStrictMinMaxRectI2(item.min, item.max.GetWithX(split));
            right = RectI2Extensions.CreateStrictMinMaxRectI2(item.min.GetWithX(split), item.max);
        }
        static public void SplitByXLeftOffset(this RectI2 item, int x_offset, out RectI2 left, out RectI2 right)
        {
            item.SplitByX(item.GetLeft() + x_offset, out left, out right);
        }
        static public void SplitByXRightOffset(this RectI2 item, int x_offset, out RectI2 left, out RectI2 right)
        {
            item.SplitByX(item.GetRight() - x_offset, out left, out right);
        }

        static public void SplitByY(this RectI2 item, int y, out RectI2 bottom, out RectI2 top)
        {
            int split = y.Min(item.GetTop());

            bottom = RectI2Extensions.CreateStrictMinMaxRectI2(item.min, item.max.GetWithY(split));
            top = RectI2Extensions.CreateStrictMinMaxRectI2(item.min.GetWithY(split), item.max);
            
        }
        static public void SplitByYBottomOffset(this RectI2 item, int y_offset, out RectI2 bottom, out RectI2 top)
        {
            item.SplitByY(item.GetBottom() + y_offset, out bottom, out top);
        }
        static public void SplitByYTopOffset(this RectI2 item, int y_offset, out RectI2 bottom, out RectI2 top)
        {
            item.SplitByY(item.GetTop() - y_offset, out bottom, out top);
        }

        static public void SplitBySideOffset(this RectI2 item, int offset, RectSide side, out RectI2 center, out RectI2 edge)
        {
            switch (side)
            {
                case RectSide.Left: item.SplitByXLeftOffset(offset, out edge, out center); break;
                case RectSide.Right: item.SplitByXRightOffset(offset, out center, out edge); break;
                case RectSide.Bottom: item.SplitByYBottomOffset(offset, out edge, out center); break;
                case RectSide.Top: item.SplitByYTopOffset(offset, out center, out edge); break;
            }

            throw new UnaccountedBranchException("side", side);
        }
    }
}