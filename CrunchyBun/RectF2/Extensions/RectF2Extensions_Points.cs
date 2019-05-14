using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class RectF2Extensions_Points
    {
        static public VectorF2 GetLowerLeftPoint(this RectF2 item)
        {
            return item.min;
        }

        static public VectorF2 GetUpperRightPoint(this RectF2 item)
        {
            return item.max;
        }

        static public VectorF2 GetLowerRightPoint(this RectF2 item)
        {
            return new VectorF2(item.GetRight(), item.GetBottom());
        }

        static public VectorF2 GetUpperLeftPoint(this RectF2 item)
        {
            return new VectorF2(item.GetLeft(), item.GetTop());
        }

        static public VectorF2 GetCenterPoint(this RectF2 item)
        {
            return new VectorF2(item.GetHorizontalCenter(), item.GetVerticalCenter());
        }
    }
}