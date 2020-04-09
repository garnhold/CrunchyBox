using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class CardinalOrdinalDirectionExtensions_GamepadStickZone
    {
        static public GamepadStickZone GetGamepadStickZone(this CardinalOrdinalDirection item)
        {
            switch (item)
            {
                case CardinalOrdinalDirection.Right: return GamepadStickZone.Right;
                case CardinalOrdinalDirection.RightUp: return GamepadStickZone.RightUp;
                case CardinalOrdinalDirection.Up: return GamepadStickZone.Up;
                case CardinalOrdinalDirection.LeftUp: return GamepadStickZone.LeftUp;
                case CardinalOrdinalDirection.Left: return GamepadStickZone.Left;
                case CardinalOrdinalDirection.LeftDown: return GamepadStickZone.LeftDown;
                case CardinalOrdinalDirection.Down: return GamepadStickZone.Down;
                case CardinalOrdinalDirection.RightDown: return GamepadStickZone.RightDown;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}