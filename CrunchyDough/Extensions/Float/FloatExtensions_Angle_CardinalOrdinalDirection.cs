using System;

namespace Crunchy.Dough
{    
    static public class FloatExtensions_Angle_CardinalOrdinalDirection
    {
        static public CardinalOrdinalDirection GetAngleClosestCardinalOrdinalDirection(this float item, float period)
        {
            float sixteenth = period / 16.0f;

            item = item.GetLooped(period);

            if (item < sixteenth)
                return CardinalOrdinalDirection.Right;

            if (item < sixteenth * 3.0f)
                return CardinalOrdinalDirection.RightUp;

            if (item < sixteenth * 5.0f)
                return CardinalOrdinalDirection.Up;

            if (item < sixteenth * 7.0f)
                return CardinalOrdinalDirection.LeftUp;

            if (item < sixteenth * 9.0f)
                return CardinalOrdinalDirection.Left;

            if (item < sixteenth * 11.0f)
                return CardinalOrdinalDirection.LeftDown;

            if (item < sixteenth * 13.0f)
                return CardinalOrdinalDirection.Down;

            if (item < sixteenth * 15.0f)
                return CardinalOrdinalDirection.RightDown;

            return CardinalOrdinalDirection.Right;
        }

        static public CardinalOrdinalDirection GetRadianAngleClosestCardinalOrdinalDirection(this float item)
        {
            return item.GetAngleClosestCardinalOrdinalDirection(Mathq.FULL_REVOLUTION_RADIANS);
        }

        static public CardinalOrdinalDirection GetDegreeAngleClosestCardinalOrdinalDirection(this float item)
        {
            return item.GetAngleClosestCardinalOrdinalDirection(Mathq.FULL_REVOLUTION_DEGREES);
        }

        static public CardinalOrdinalDirection GetPercentAngleClosestCardinalOrdinalDirection(this float item)
        {
            return item.GetAngleClosestCardinalOrdinalDirection(Mathq.FULL_REVOLUTION_PERCENT);
        }
    }
}