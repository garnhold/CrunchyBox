using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_Angle_HorizontalDirection
    {
        static public HorizontalDirection GetAngleClosestHorizontalDirection(this float item, float period)
        {
            item = item.GetLooped(period);

            if (item < period * 0.25f)
                return HorizontalDirection.Right;

            if (item < period * 0.75f)
                return HorizontalDirection.Left;

            return HorizontalDirection.Right;
        }

        static public HorizontalDirection GetRadianAngleClosestHorizontalDirection(this float item)
        {
            return item.GetAngleClosestHorizontalDirection(Mathq.FULL_REVOLUTION_RADIANS);
        }

        static public HorizontalDirection GetDegreeAngleClosestHorizontalDirection(this float item)
        {
            return item.GetAngleClosestHorizontalDirection(Mathq.FULL_REVOLUTION_DEGREES);
        }

        static public HorizontalDirection GetPercentAngleClosestHorizontalDirection(this float item)
        {
            return item.GetAngleClosestHorizontalDirection(Mathq.FULL_REVOLUTION_PERCENT);
        }
    }
}