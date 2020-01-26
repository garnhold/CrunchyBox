using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_Split_Center
    {
        static public void SplitByXCenter(this RectF2 item, out RectF2 left, out RectF2 right)
        {
            item.SplitByX(item.GetHorizontalCenter(), out left, out right);
        }

        static public void SplitByYCenter(this RectF2 item, out RectF2 bottom, out RectF2 top)
        {
            item.SplitByY(item.GetVerticalCenter(), out bottom, out top);
        }
    }
}