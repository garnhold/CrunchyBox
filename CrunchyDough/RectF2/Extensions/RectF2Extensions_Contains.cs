using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_Contains
    {
        static public bool Contains(this RectF2 item, VectorF2 point)
        {
            if (point.IsBoundAbove(item.min))
            {
                if (point.IsBoundBelow(item.max))
                    return true;
            }

            return false;
        }

        static public bool FullyContains(this RectF2 item, RectF2 target)
        {
            if (item.GetLeft() <= target.GetLeft() && item.GetRight() >= target.GetRight())
            {
                if (item.GetBottom() <= target.GetBottom() && item.GetTop() >= target.GetTop())
                    return true;
            }

            return false;
        }

        static public bool CouldContain(this RectF2 item, RectF2 target)
        {
            if (item.GetWidth() >= target.GetWidth())
            {
                if (item.GetHeight() >= target.GetHeight())
                    return true;
            }

            return false;
        }
    }
}