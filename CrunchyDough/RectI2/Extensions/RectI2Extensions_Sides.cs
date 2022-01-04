using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Sides
    {
        static public int GetLeft(this RectI2 item)
        {
            return item.min.x;
        }

        static public int GetRight(this RectI2 item)
        {
            return item.max.x;
        }

        static public int GetBottom(this RectI2 item)
        {
            return item.min.y;
        }

        static public int GetTop(this RectI2 item)
        {
            return item.max.y;
        }

        static public int GetSide(this RectI2 item, RectSide side)
        {
            switch (side)
            {
                case RectSide.Left: return item.GetLeft();
                case RectSide.Right: return item.GetRight();
                case RectSide.Bottom: return item.GetBottom();
                case RectSide.Top: return item.GetTop();
            }

            throw new UnaccountedBranchException("side", side);
        }

        static public float GetHorizontalCenter(this RectI2 item)
        {
            return (item.min.x + item.max.x) * 0.5f;
        }

        static public float GetVerticalCenter(this RectI2 item)
        {
            return (item.min.y + item.max.y) * 0.5f;
        }
    }
}