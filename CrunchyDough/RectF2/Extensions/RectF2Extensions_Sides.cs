using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_Sides
    {
        static public float GetLeft(this RectF2 item)
        {
            return item.min.x;
        }

        static public float GetRight(this RectF2 item)
        {
            return item.max.x;
        }

        static public float GetBottom(this RectF2 item)
        {
            return item.min.y;
        }

        static public float GetTop(this RectF2 item)
        {
            return item.max.y;
        }

        static public float GetSide(this RectF2 item, RectSide side)
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

        static public float GetHorizontalCenter(this RectF2 item)
        {
            return (item.min.x + item.max.x) * 0.5f;
        }

        static public float GetVerticalCenter(this RectF2 item)
        {
            return (item.min.y + item.max.y) * 0.5f;
        }
    }
}