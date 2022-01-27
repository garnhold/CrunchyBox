using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectF2Extensions_Convert
    {
        static public VectorF2 ConvertPercentPointToRangePoint(this RectF2 item, VectorF2 point)
        {
            return point.ConvertFromPercentToRange(item.GetHorizontalRange(), item.GetVerticalRange());
        }

        static public VectorF2 ConvertRangePointToPercentPoint(this RectF2 item, VectorF2 point)
        {
            return point.ConvertFromRangeToPercent(item.GetHorizontalRange(), item.GetVerticalRange());
        }
    }
}