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
    }
}