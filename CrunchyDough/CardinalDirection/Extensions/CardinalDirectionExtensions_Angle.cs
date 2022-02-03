using System;

namespace Crunchy.Dough
{    
    static public class CardinalDirectionExtensions_Angle
    {
        static public float GetAngleInPercent(this CardinalDirection item)
        {
            switch (item)
            {
                case CardinalDirection.Right: return 0.0f / 4.0f;
                case CardinalDirection.Up: return 1.0f / 4.0f;
                case CardinalDirection.Left: return 2.0f / 4.0f;
                case CardinalDirection.Down: return 3.0f / 4.0f;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public float GetAngleInRadians(this CardinalDirection item)
        {
            return item.GetAngleInPercent() * Mathq.FULL_REVOLUTION_RADIANS;
        }

        static public float GetAngleInDegrees(this CardinalDirection item)
        {
            return item.GetAngleInPercent() * Mathq.FULL_REVOLUTION_DEGREES;
        }
    }
}