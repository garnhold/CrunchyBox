using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class RectExtensions_Convert
    {
        static public Vector2 ConvertPercentPointToRangePoint(this Rect item, Vector2 point)
        {
            return point.ConvertFromPercentToRange(item.GetHorizontalRange(), item.GetVerticalRange());
        }

        static public Vector2 ConvertRangePointToPercentPoint(this Rect item, Vector2 point)
        {
            return point.ConvertFromRangeToPercent(item.GetHorizontalRange(), item.GetVerticalRange());
        }
    }
}