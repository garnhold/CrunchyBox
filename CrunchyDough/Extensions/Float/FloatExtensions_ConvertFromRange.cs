using System;

namespace Crunchy.Dough
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

        static public float ConvertFromRangeToRange(this float item, float src_lower, float src_upper, float dst_lower, float dst_upper)
        {
            return item.ConvertFromRangeToPercent(src_lower, src_upper)
                .ConvertFromPercentToRange(dst_lower, dst_upper);
        }
        static public float ConvertFromRangeToRange(this float item, FloatRange src, FloatRange dst)
        {
            return item.ConvertFromRangeToRange(src.x1, src.x2, dst.x1, dst.x2);
        }
    }
}