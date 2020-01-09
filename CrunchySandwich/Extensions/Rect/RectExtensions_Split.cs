using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RectExtensions_Split
    {
        static public void SplitByX(this Rect item, float x, out Rect left, out Rect right)
        {
            float split = x.Min(item.xMax);

            left = RectExtensions.CreateStrictMinMaxRect(item.min, item.max.GetWithX(split));
            right = RectExtensions.CreateStrictMinMaxRect(item.min.GetWithX(split), item.max);
        }
        static public void SplitByXLeftOffset(this Rect item, float x_offset, out Rect left, out Rect right)
        {
            item.SplitByX(item.xMin + x_offset, out left, out right);
        }
        static public void SplitByXRightOffset(this Rect item, float x_offset, out Rect left, out Rect right)
        {
            item.SplitByX(item.xMax - x_offset, out left, out right);
        }

        static public void SplitByXLeftPercent(this Rect item, float x_percent, out Rect left, out Rect right)
        {
            item.SplitByXLeftOffset(item.width * x_percent, out left, out right);
        }
        static public void SplitByXRightPercent(this Rect item, float x_percent, out Rect left, out Rect right)
        {
            item.SplitByXRightOffset(item.width * x_percent, out left, out right);
        }

        static public void SplitByXCenterOffset(this Rect item, float x_offset, out Rect left, out Rect right)
        {
            item.SplitByX(item.center.x + x_offset, out left, out right);
        }

        static public void SplitByXCenter(this Rect item, out Rect left, out Rect right)
        {
            item.SplitByX(item.center.x, out left, out right);
        }

        static public void SplitByY(this Rect item, float y, out Rect bottom, out Rect top)
        {
            float split = y.Min(item.yMax);

            bottom = RectExtensions.CreateStrictMinMaxRect(item.min, item.max.GetWithY(split));
            top = RectExtensions.CreateStrictMinMaxRect(item.min.GetWithY(split), item.max);
            
        }
        static public void SplitByYBottomOffset(this Rect item, float y_offset, out Rect bottom, out Rect top)
        {
            item.SplitByY(item.yMin + y_offset, out bottom, out top);
        }
        static public void SplitByYTopOffset(this Rect item, float y_offset, out Rect bottom, out Rect top)
        {
            item.SplitByY(item.yMax - y_offset, out bottom, out top);
        }

        static public void SplitByYBottomPercent(this Rect item, float y_percent, out Rect bottom, out Rect top)
        {
            item.SplitByYBottomOffset(item.height * y_percent, out bottom, out top);
        }
        static public void SplitByYTopPercent(this Rect item, float y_percent, out Rect bottom, out Rect top)
        {
            item.SplitByYTopOffset(item.height * y_percent, out bottom, out top);
        }

        static public void SplitByYCenterOffset(this Rect item, float y_offset, out Rect bottom, out Rect top)
        {
            item.SplitByY(item.center.y + y_offset, out bottom, out top);
        }

        static public void SplitByYCenter(this Rect item, out Rect bottom, out Rect top)
        {
            item.SplitByY(item.center.y, out bottom, out top);
        }
    }
}