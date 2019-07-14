using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class CardinalOrdinalDirectionExtensions_Angle
    {
        static public float GetAngleInPercent(this CardinalOrdinalDirection item)
        {
            switch (item)
            {
                case CardinalOrdinalDirection.Right: return 0.0f / 8.0f;
                case CardinalOrdinalDirection.RightUp: return 1.0f / 8.0f;
                case CardinalOrdinalDirection.Up: return 2.0f / 8.0f;
                case CardinalOrdinalDirection.LeftUp: return 3.0f / 8.0f;
                case CardinalOrdinalDirection.Left: return 4.0f / 8.0f;
                case CardinalOrdinalDirection.LeftDown: return 5.0f / 8.0f;
                case CardinalOrdinalDirection.Down: return 6.0f / 8.0f;
                case CardinalOrdinalDirection.RightDown: return 7.0f / 8.0f;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public float GetAngleInDegrees(this CardinalOrdinalDirection item)
        {
            return item.GetAngleInPercent() * Mathq.FULL_REVOLUTION_DEGREES;
        }

        static public float GetAngleInRadians(this CardinalOrdinalDirection item)
        {
            return item.GetAngleInPercent() * Mathq.FULL_REVOLUTION_RADIANS;
        }
    }
}