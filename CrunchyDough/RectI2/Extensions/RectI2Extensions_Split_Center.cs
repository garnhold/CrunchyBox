using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_Split_Center
    {
        static public void SplitByXCenter(this RectI2 item, out RectI2 left, out RectI2 right)
        {
            item.SplitByX((int)item.GetHorizontalCenter(), out left, out right);
        }

        static public void SplitByYCenter(this RectI2 item, out RectI2 bottom, out RectI2 top)
        {
            item.SplitByY((int)item.GetVerticalCenter(), out bottom, out top);
        }
    }
}