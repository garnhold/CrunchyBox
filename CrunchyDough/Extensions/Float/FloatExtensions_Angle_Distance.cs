using System;

namespace Crunchy.Dough
{    
    static public class FloatExtensions_Angle_Distance
    {
        static public float GetAngleDistance(this float item, float angle, float period)
        {
            return item.GetAngleDifference(angle, period).GetAbs();
        }

        static public float GetRadianAngleDistance(this float item, float angle)
        {
            return item.GetAngleDistance(angle, Mathq.FULL_REVOLUTION_RADIANS);
        }

        static public float GetDegreeAngleDistance(this float item, float angle)
        {
            return item.GetAngleDistance(angle, Mathq.FULL_REVOLUTION_DEGREES);
        }

        static public float GetPercentAngleDistance(this float item, float angle)
        {
            return item.GetAngleDistance(angle, Mathq.FULL_REVOLUTION_PERCENT);
        }
    }
}