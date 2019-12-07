using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class CardinalOrdinalDirectionExtensions_InputDeviceComponentStickZone
    {
        static public InputDeviceStickZone GetInputDeviceComponentStickZone(this CardinalOrdinalDirection item)
        {
            switch (item)
            {
                case CardinalOrdinalDirection.Right: return InputDeviceStickZone.Right;
                case CardinalOrdinalDirection.RightUp: return InputDeviceStickZone.RightUp;
                case CardinalOrdinalDirection.Up: return InputDeviceStickZone.Up;
                case CardinalOrdinalDirection.LeftUp: return InputDeviceStickZone.LeftUp;
                case CardinalOrdinalDirection.Left: return InputDeviceStickZone.Left;
                case CardinalOrdinalDirection.LeftDown: return InputDeviceStickZone.LeftDown;
                case CardinalOrdinalDirection.Down: return InputDeviceStickZone.Down;
                case CardinalOrdinalDirection.RightDown: return InputDeviceStickZone.RightDown;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}