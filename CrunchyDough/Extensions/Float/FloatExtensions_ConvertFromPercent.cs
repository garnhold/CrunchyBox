using System;

namespace Crunchy.Dough
{    
    static public class FloatExtensions_ConvertFromPercent
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
    }
}