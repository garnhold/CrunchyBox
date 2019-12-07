using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
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
    }
}