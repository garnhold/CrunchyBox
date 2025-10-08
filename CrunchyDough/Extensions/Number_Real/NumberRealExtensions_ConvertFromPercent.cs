using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class NumberRealExtensions_ConvertFromPercent
    {
        static public float ConvertFromPercentToOffset(this float item)
        {
            return (item * 2.0f) - 1.0f;
        }

        static public float ConvertFromPercentToRange(this float item, float lower, float upper)
        {
            return item * (upper - lower) + lower;
        }
        static public float ConvertFromPercentToRange(this float item, FloatRange range)
        {
            return item.ConvertFromPercentToRange(range.x1, range.x2);
        }

        static public float ConvertFromPercentToVariance(this float item, float value, float radius)
        {
            return item.ConvertFromPercentToOffset().ConvertFromOffsetToVariance(value, radius);
        }
        static public float ConvertFromPercentToVariance(this float item, FloatVariance variance)
        {
            return item.ConvertFromPercentToVariance(variance.value, variance.radius);
        }
        
        static public double ConvertFromPercentToOffset(this double item)
        {
            return (item * 2.0) - 1.0;
        }

        static public double ConvertFromPercentToRange(this double item, double lower, double upper)
        {
            return item * (upper - lower) + lower;
        }
        static public double ConvertFromPercentToRange(this double item, DoubleRange range)
        {
            return item.ConvertFromPercentToRange(range.x1, range.x2);
        }

        static public double ConvertFromPercentToVariance(this double item, double value, double radius)
        {
            return item.ConvertFromPercentToOffset().ConvertFromOffsetToVariance(value, radius);
        }
        static public double ConvertFromPercentToVariance(this double item, DoubleVariance variance)
        {
            return item.ConvertFromPercentToVariance(variance.value, variance.radius);
        }
        
        static public decimal ConvertFromPercentToOffset(this decimal item)
        {
            return (item * 2.0m) - 1.0m;
        }

        static public decimal ConvertFromPercentToRange(this decimal item, decimal lower, decimal upper)
        {
            return item * (upper - lower) + lower;
        }
        static public decimal ConvertFromPercentToRange(this decimal item, DecimalRange range)
        {
            return item.ConvertFromPercentToRange(range.x1, range.x2);
        }

        static public decimal ConvertFromPercentToVariance(this decimal item, decimal value, decimal radius)
        {
            return item.ConvertFromPercentToOffset().ConvertFromOffsetToVariance(value, radius);
        }
        static public decimal ConvertFromPercentToVariance(this decimal item, DecimalVariance variance)
        {
            return item.ConvertFromPercentToVariance(variance.value, variance.radius);
        }
        
    }
}

