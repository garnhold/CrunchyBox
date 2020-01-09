using System;

namespace Crunchy.Bun
{
    static public class TrigPercent
    {
        static private readonly float RADIANS_PER_PERCENT = Mathq.PI2;

        static public float Sin(float percent)
        {
            return TrigRadian.Sin(percent * RADIANS_PER_PERCENT);
        }

        static public float Cos(float percent)
        {
            return TrigRadian.Cos(percent * RADIANS_PER_PERCENT);
        }

        static public float Atan2(float y, float x)
        {
            return TrigRadian.Atan2(y, x) / RADIANS_PER_PERCENT;
        }
    }
}