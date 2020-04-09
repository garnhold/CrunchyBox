using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class GamepadStickZoneExtensions_Vector2
    {
        static public VectorF2 GetVectorF2(this GamepadStickZone item)
        {
            if (item == GamepadStickZone.Center)
                return VectorF2.ZERO;

            return item.GetCardinalOrdinalDirection().GetVectorF2();
        }
    }
}