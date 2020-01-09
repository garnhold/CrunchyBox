using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_Angle_Interpolate
    {
        static public float GetInterpolateAngle(this float item, float target, float period, float amount)
        {
            item.GetAsNearAngles(target, period, out item, out target);

            return item.GetInterpolate(target, amount);
        }

        static public float GetInterpolateAngleInRadians(this float item, float target, float amount)
        {
            return item.GetInterpolateAngle(target, Mathq.FULL_REVOLUTION_RADIANS, amount);
        }

        static public float GetInterpolateAngleInDegrees(this float item, float target, float amount)
        {
            return item.GetInterpolateAngle(target, Mathq.FULL_REVOLUTION_DEGREES, amount);
        }

        static public float GetInterpolateAngleInPercent(this float item, float target, float amount)
        {
            return item.GetInterpolateAngle(target, Mathq.FULL_REVOLUTION_PERCENT, amount);
        }
    }
}