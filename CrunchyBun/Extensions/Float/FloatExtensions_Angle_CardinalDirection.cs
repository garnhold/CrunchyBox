using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_Angle_CardinalDirection
    {
        static public CardinalDirection GetAngleClosestCardinalDirection(this float item, float period)
        {
            item = item.GetLooped(period);

            if (item < period * (0.125f))
                return CardinalDirection.Right;

            if (item < period * (0.125f + 0.25f))
                return CardinalDirection.Up;

            if (item < period * (0.125f + 0.25f + 0.25f))
                return CardinalDirection.Left;

            if (item < period * (0.125f + 0.25f + 0.25f + 0.25f))
                return CardinalDirection.Down;

            return CardinalDirection.Right;
        }

        static public CardinalDirection GetRadianAngleClosestCardinalDirection(this float item)
        {
            return item.GetAngleClosestCardinalDirection(Mathq.FULL_REVOLUTION_RADIANS);
        }

        static public CardinalDirection GetDegreeAngleClosestCardinalDirection(this float item)
        {
            return item.GetAngleClosestCardinalDirection(Mathq.FULL_REVOLUTION_DEGREES);
        }

        static public CardinalDirection GetPercentAngleClosestCardinalDirection(this float item)
        {
            return item.GetAngleClosestCardinalDirection(Mathq.FULL_REVOLUTION_PERCENT);
        }
    }
}