using System;

namespace CrunchyBun
{
    static public class TrigDegree
    {
        static private readonly float DEGREES_PER_PERIOD = 360.0f;

        static public float Sin(float degrees)
        {
            return TrigCustom.Sin(degrees, DEGREES_PER_PERIOD);
        }

        static public float Cos(float degrees)
        {
            return TrigCustom.Cos(degrees, DEGREES_PER_PERIOD);
        }

        static public float Atan2(float y, float x)
        {
            return TrigCustom.Atan2(y, x, DEGREES_PER_PERIOD);
        }
    }
}