using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class GamepadStickZoneExtensions_CardinalOrdinalDirection
    {
        static public CardinalOrdinalDirection GetCardinalOrdinalDirection(this GamepadStickZone item)
        {
            switch (item)
            {
                case GamepadStickZone.Center: return CardinalOrdinalDirection.Right;

                case GamepadStickZone.Right: return CardinalOrdinalDirection.Right;
                case GamepadStickZone.RightUp: return CardinalOrdinalDirection.RightUp;
                case GamepadStickZone.Up: return CardinalOrdinalDirection.Up;
                case GamepadStickZone.LeftUp: return CardinalOrdinalDirection.LeftUp;
                case GamepadStickZone.Left: return CardinalOrdinalDirection.Left;
                case GamepadStickZone.LeftDown: return CardinalOrdinalDirection.LeftDown;
                case GamepadStickZone.Down: return CardinalOrdinalDirection.Down;
                case GamepadStickZone.RightDown: return CardinalOrdinalDirection.RightDown;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}