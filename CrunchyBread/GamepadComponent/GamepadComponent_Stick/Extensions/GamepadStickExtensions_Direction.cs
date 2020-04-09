using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class GamepadComponentStickExtensions_Direction
    {
        static public HorizontalDirection GetClosestHorizontalDirection(this GamepadComponent_Stick item)
        {
            return item.GetAngleInDegrees().GetDegreeAngleClosestHorizontalDirection();
        }

        static public CardinalDirection GetClosestCardinalDirection(this GamepadComponent_Stick item)
        {
            return item.GetAngleInDegrees().GetDegreeAngleClosestCardinalDirection();
        }

        static public CardinalOrdinalDirection GetClosestCardinalOrdinalDirection(this GamepadComponent_Stick item)
        {
            return item.GetAngleInDegrees().GetDegreeAngleClosestCardinalOrdinalDirection();
        }
    }
}