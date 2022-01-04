using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Slice
    {
        static public RectI2 GetLeftSlice(this RectI2 item, int amount)
        {
            return RectI2Extensions.CreateStrictMinMaxRectI2(
                item.GetLeft(),
                item.GetBottom(),
                (item.GetLeft() + amount).BindBelow(item.GetRight()),
                item.GetTop()
            );
        }

        static public RectI2 GetRightSlice(this RectI2 item, int amount)
        {
            return RectI2Extensions.CreateStrictMinMaxRectI2(
                (item.GetRight() - amount).BindAbove(item.GetLeft()),
                item.GetBottom(),
                item.GetRight(),
                item.GetTop()
            );
        }

        static public RectI2 GetBottomSlice(this RectI2 item, int amount)
        {
            return RectI2Extensions.CreateStrictMinMaxRectI2(
                item.GetLeft(),
                item.GetBottom(),
                item.GetRight(),
                (item.GetBottom() + amount).BindBelow(item.GetTop())
            );
        }

        static public RectI2 GetTopSlice(this RectI2 item, int amount)
        {
            return RectI2Extensions.CreateStrictMinMaxRectI2(
                item.GetLeft(),
                (item.GetTop() - amount).BindAbove(item.GetBottom()),
                item.GetRight(),
                item.GetTop()
            );
        }

        static public RectI2 GetSlice(this RectI2 item, int amount, RectSide side)
        {
            switch (side)
            {
                case RectSide.Left: return item.GetLeftSlice(amount);
                case RectSide.Right: return item.GetRightSlice(amount);
                case RectSide.Bottom: return item.GetBottomSlice(amount);
                case RectSide.Top: return item.GetTopSlice(amount);
            }

            throw new UnaccountedBranchException("side", side);
        }
    }
}