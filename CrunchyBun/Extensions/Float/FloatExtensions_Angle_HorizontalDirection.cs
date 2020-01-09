using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_Angle_HorizontalDirection
    {
        static public HorizontalDirection GetAngleClosestHorizontalDirection(this float item, float period)
        {
            float quarter = period / 4.0f;

            item = item.GetLooped(period);

            if (item < quarter)
                return HorizontalDirection.Right;

            if (item < quarter * 3.0f)
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