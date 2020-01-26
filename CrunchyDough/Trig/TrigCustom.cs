using System;

namespace Crunchy.Dough
{
    static public class TrigCustom
    {
        static public float Sin(float value, float period)
        {
            return TrigPercent.Sin(value / period);
        }

        static public float Cos(float value, float period)
        {
            return TrigPercent.Cos(value / period);
        }

        static public float Atan2(float y, float x, float period)
        {
            return TrigPercent.Atan2(y, x) * period;
        }
    }
}