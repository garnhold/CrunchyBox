using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_ConvertFromRange
    {
        static public float ConvertFromRangeToOffset(this float item, float lower, float upper)
        {
            return item.ConvertFromRangeToPercent(lower, upper).ConvertFromPercentToOffset();
        }
        static public float ConvertFromRangeToOffset(this float item, FloatRange range)
        {
            return item.ConvertFromRangeToOffset(range.x1, range.x2);
        }

        static public float ConvertFromRangeToPercent(this float item, float lower, float upper)
        {
            return (item - lower) / (upper - lower);
        }
        static public float ConvertFromRangeToPercent(this float item, FloatRange range)
        {
            return item.ConvertFromRangeToPercent(range.x1, range.x2);
        }
    }
}