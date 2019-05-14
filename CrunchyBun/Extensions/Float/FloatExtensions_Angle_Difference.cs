using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_Angle_Difference
    {
        static public float GetAngleDifference(this float item, float angle, float period)
        {
            item.GetAsNearAngles(angle, period, out item, out angle);
            return item - angle;
        }

        static public float GetRadianAngleDifference(this float item, float angle)
        {
            return item.GetAngleDifference(angle, Mathq.FULL_REVOLUTION_RADIANS);
        }

        static public float GetDegreeAngleDifference(this float item, float angle)
        {
            return item.GetAngleDifference(angle, Mathq.FULL_REVOLUTION_DEGREES);
        }

        static public float GetPercentAngleDifference(this float item, float angle)
        {
            return item.GetAngleDifference(angle, Mathq.FULL_REVOLUTION_PERCENT);
        }
    }
}