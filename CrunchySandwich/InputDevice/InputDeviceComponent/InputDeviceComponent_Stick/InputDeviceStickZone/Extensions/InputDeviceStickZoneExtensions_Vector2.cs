using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class InputDeviceStickZoneExtensions_Vector2
    {
        static public Vector2 GetVector2(this InputDeviceStickZone item)
        {
            if (item == InputDeviceStickZone.Center)
                return Vector2.zero;

            return item.GetCardinalOrdinalDirection().GetVector2();
        }
    }
}