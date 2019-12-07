using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_Angle_Mix
    {
        static public float GetAngleMix(this float item, float angle_a, float angle_b, float period)
        {
            item.GetAsNearAngles(angle_a, angle_b, period, out item, out angle_a, out angle_b);
            return item.ConvertFromRangeToPercent(angle_a, angle_b);
        }
        static public float GetAngleMixInRadians(this float item, float angle_a, float angle_b)
        {
            return item.GetAngleMix(angle_a, angle_b, Mathq.FULL_REVOLUTION_RADIANS);
        }
        static public float GetAngleMixInDegrees(this float item, float angle_a, float angle_b)
        {
            return item.GetAngleMix(angle_a, angle_b, Mathq.FULL_REVOLUTION_DEGREES);
        }
        static public float GetAngleMixInPercent(this float item, float angle_a, float angle_b)
        {
            return item.GetAngleMix(angle_a, angle_b, Mathq.FULL_REVOLUTION_PERCENT);
        }
    }
}