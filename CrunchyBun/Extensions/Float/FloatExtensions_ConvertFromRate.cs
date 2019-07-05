using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_ConvertFromRate
    {
        static public int ConvertFromRateToCount(this float item, float time)
        {
            return item.ConvertFromDensityToCount(time);
        }
    }
}