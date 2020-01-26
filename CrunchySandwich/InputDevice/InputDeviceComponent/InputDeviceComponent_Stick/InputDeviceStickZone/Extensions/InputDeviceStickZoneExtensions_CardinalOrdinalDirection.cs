using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class InputDeviceStickZoneExtensions_CardinalOrdinalDirection
    {
        static public CardinalOrdinalDirection GetCardinalOrdinalDirection(this InputDeviceStickZone item)
        {
            switch (item)
            {
                case InputDeviceStickZone.Center: return CardinalOrdinalDirection.Right;

                case InputDeviceStickZone.Right: return CardinalOrdinalDirection.Right;
                case InputDeviceStickZone.RightUp: return CardinalOrdinalDirection.RightUp;
                case InputDeviceStickZone.Up: return CardinalOrdinalDirection.Up;
                case InputDeviceStickZone.LeftUp: return CardinalOrdinalDirection.LeftUp;
                case InputDeviceStickZone.Left: return CardinalOrdinalDirection.Left;
                case InputDeviceStickZone.LeftDown: return CardinalOrdinalDirection.LeftDown;
                case InputDeviceStickZone.Down: return CardinalOrdinalDirection.Down;
                case InputDeviceStickZone.RightDown: return CardinalOrdinalDirection.RightDown;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}