using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class NumberRealExtensions_ConvertFromOffset
    {
        static public float ConvertFromOffsetToPercent(this float item)
        {
            return (item + 1.0f) * 0.5f;
        }

        static public float ConvertFromOffsetToRange(this float item, float lower, float upper)
        {
            return item.ConvertFromOffsetToPercent().ConvertFromPercentToRange(lower, upper);
        }
        static public float ConvertFromOffsetToRange(this float item, FloatRange range)
        {
            return item.ConvertFromOffsetToRange(range.x1, range.x2);
        }

        static public float ConvertFromOffsetToVariance(this float item, float value, float radius)
        {
            return item * radius + value;
        }
        static public float ConvertFromOffsetToVariance(this float item, FloatVariance variance)
        {
            return item.ConvertFromVarianceToOffset(variance.value, variance.radius);
        }
        
        static public double ConvertFromOffsetToPercent(this double item)
        {
            return (item + 1.0) * 0.5;
        }

        static public double ConvertFromOffsetToRange(this double item, double lower, double upper)
        {
            return item.ConvertFromOffsetToPercent().ConvertFromPercentToRange(lower, upper);
        }
        static public double ConvertFromOffsetToRange(this double item, DoubleRange range)
        {
            return item.ConvertFromOffsetToRange(range.x1, range.x2);
        }

        static public double ConvertFromOffsetToVariance(this double item, double value, double radius)
        {
            return item * radius + value;
        }
        static public double ConvertFromOffsetToVariance(this double item, DoubleVariance variance)
        {
            return item.ConvertFromVarianceToOffset(variance.value, variance.radius);
        }
        
        static public decimal ConvertFromOffsetToPercent(this decimal item)
        {
            return (item + 1.0m) * 0.5m;
        }

        static public decimal ConvertFromOffsetToRange(this decimal item, decimal lower, decimal upper)
        {
            return item.ConvertFromOffsetToPercent().ConvertFromPercentToRange(lower, upper);
        }
        static public decimal ConvertFromOffsetToRange(this decimal item, DecimalRange range)
        {
            return item.ConvertFromOffsetToRange(range.x1, range.x2);
        }

        static public decimal ConvertFromOffsetToVariance(this decimal item, decimal value, decimal radius)
        {
            return item * radius + value;
        }
        static public decimal ConvertFromOffsetToVariance(this decimal item, DecimalVariance variance)
        {
            return item.ConvertFromVarianceToOffset(variance.value, variance.radius);
        }
        
    }
}

