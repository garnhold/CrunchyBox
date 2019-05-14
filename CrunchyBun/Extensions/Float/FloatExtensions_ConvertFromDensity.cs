using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_ConvertFromDensity
    {
        static public int ConvertFromDensityToCount(this float item, float size)
        {
            float full_count = item * size;
            int int_count = (int)full_count;
            float float_count = full_count - int_count;

            if (RandChance.Get(float_count))
                int_count++;

            return int_count;
        }
    }
}