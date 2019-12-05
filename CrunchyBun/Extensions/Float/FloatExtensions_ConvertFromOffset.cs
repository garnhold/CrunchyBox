using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_ConvertFromOffset
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
    }
}