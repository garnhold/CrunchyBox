using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_Angle_CardinalDirection
    {
        static public CardinalDirection GetAngleClosestCardinalDirection(this float item, float period)
        {
            float eighth = period / 8.0f;

            item = item.GetLooped(period);

            if (item < eighth)
                return CardinalDirection.Right;

            if (item < eighth * 3.0f)
                return CardinalDirection.Up;

            if (item < eighth * 5.0f)
                return CardinalDirection.Left;

            if (item < eighth * 7.0f)
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