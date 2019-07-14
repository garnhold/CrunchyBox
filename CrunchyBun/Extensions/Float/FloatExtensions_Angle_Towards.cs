using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_Angle_Towards
    {
        static public float GetTowardsAngle(this float item, float target, float period, float amount)
        {
            item.GetAsNearAngles(target, period, out item, out target);

            return item.GetTowards(target, amount);
        }

        static public float GetTowardsAngleInRadians(this float item, float target, float amount)
        {
            return item.GetTowardsAngle(target, Mathq.FULL_REVOLUTION_RADIANS, amount);
        }

        static public float GetTowardsAngleInDegrees(this float item, float target, float amount)
        {
            return item.GetTowardsAngle(target, Mathq.FULL_REVOLUTION_DEGREES, amount);
        }

        static public float GetTowardsAngleInPercent(this float item, float target, float amount)
        {
            return item.GetTowardsAngle(target, Mathq.FULL_REVOLUTION_PERCENT, amount);
        }
    }
}