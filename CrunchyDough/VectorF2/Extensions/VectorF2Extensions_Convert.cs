using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorF2Extensions_Convert
    {
        static public VectorF2 ConvertFromPercentToRange(this VectorF2 item, FloatRange x_range, FloatRange y_range)
        {
            return new VectorF2(
                item.x.ConvertFromPercentToRange(x_range),
                item.y.ConvertFromPercentToRange(y_range)
            );
        }
        static public VectorF2 ConvertFromPercentToRange(this VectorF2 item, FloatRange range)
        {
            return item.ConvertFromPercentToRange(range, range);
        }

        static public VectorF2 ConvertFromRangeToPercent(this VectorF2 item, FloatRange x_range, FloatRange y_range)
        {
            return new VectorF2(
                item.x.ConvertFromRangeToPercent(x_range),
                item.y.ConvertFromRangeToPercent(y_range)
            );
        }
        static public VectorF2 ConvertFromRangeToPercent(this VectorF2 item, FloatRange range)
        {
            return item.ConvertFromRangeToPercent(range, range);
        }
    }
}