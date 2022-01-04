using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_Extrude
    {
        static public Rect GetLeftExtrusion(this Rect item, float amount)
        {
            return RectExtensions.CreateMinMaxRect(
                item.xMin - amount,
                item.yMin,
                item.xMin,
                item.yMax
            );
        }

        static public Rect GetRightExtrusion(this Rect item, float amount)
        {
            return RectExtensions.CreateMinMaxRect(
                item.xMax,
                item.yMin,
                item.xMax + amount,
                item.yMax
            );
        }

        static public Rect GetBottomExtrusion(this Rect item, float amount)
        {
            return RectExtensions.CreateMinMaxRect(
                item.xMin,
                item.yMin - amount,
                item.xMax,
                item.yMin
            );
        }

        static public Rect GetTopExtrusion(this Rect item, float amount)
        {
            return RectExtensions.CreateMinMaxRect(
                item.xMin,
                item.yMax,
                item.xMax,
                item.yMax + amount
            );
        }

        static public Rect GetExtrusion(this Rect item, float amount, RectSide side)
        {
            switch (side)
            {
                case RectSide.Left: return item.GetLeftExtrusion(amount);
                case RectSide.Right: return item.GetRightExtrusion(amount);
                case RectSide.Bottom: return item.GetBottomExtrusion(amount);
                case RectSide.Top: return item.GetTopExtrusion(amount);
            }

            throw new UnaccountedBranchException("side", side);
        }
    }
}