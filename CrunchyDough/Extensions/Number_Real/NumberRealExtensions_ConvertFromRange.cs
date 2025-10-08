using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class NumberRealExtensions_ConvertFromRange
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
        
        static public double ConvertFromRangeToOffset(this double item, double lower, double upper)
        {
            return item.ConvertFromRangeToPercent(lower, upper).ConvertFromPercentToOffset();
        }
        static public double ConvertFromRangeToOffset(this double item, DoubleRange range)
        {
            return item.ConvertFromRangeToOffset(range.x1, range.x2);
        }

        static public double ConvertFromRangeToPercent(this double item, double lower, double upper)
        {
            return (item - lower) / (upper - lower);
        }
        static public double ConvertFromRangeToPercent(this double item, DoubleRange range)
        {
            return item.ConvertFromRangeToPercent(range.x1, range.x2);
        }

        static public double ConvertFromRangeToRange(this double item, double src_lower, double src_upper, double dst_lower, double dst_upper)
        {
            return item.ConvertFromRangeToPercent(src_lower, src_upper)
                .ConvertFromPercentToRange(dst_lower, dst_upper);
        }
        static public double ConvertFromRangeToRange(this double item, DoubleRange src, DoubleRange dst)
        {
            return item.ConvertFromRangeToRange(src.x1, src.x2, dst.x1, dst.x2);
        }
        
        static public decimal ConvertFromRangeToOffset(this decimal item, decimal lower, decimal upper)
        {
            return item.ConvertFromRangeToPercent(lower, upper).ConvertFromPercentToOffset();
        }
        static public decimal ConvertFromRangeToOffset(this decimal item, DecimalRange range)
        {
            return item.ConvertFromRangeToOffset(range.x1, range.x2);
        }

        static public decimal ConvertFromRangeToPercent(this decimal item, decimal lower, decimal upper)
        {
            return (item - lower) / (upper - lower);
        }
        static public decimal ConvertFromRangeToPercent(this decimal item, DecimalRange range)
        {
            return item.ConvertFromRangeToPercent(range.x1, range.x2);
        }

        static public decimal ConvertFromRangeToRange(this decimal item, decimal src_lower, decimal src_upper, decimal dst_lower, decimal dst_upper)
        {
            return item.ConvertFromRangeToPercent(src_lower, src_upper)
                .ConvertFromPercentToRange(dst_lower, dst_upper);
        }
        static public decimal ConvertFromRangeToRange(this decimal item, DecimalRange src, DecimalRange dst)
        {
            return item.ConvertFromRangeToRange(src.x1, src.x2, dst.x1, dst.x2);
        }
        
    }
}

