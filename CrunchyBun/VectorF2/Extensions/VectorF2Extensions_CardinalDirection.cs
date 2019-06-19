using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class VectorF2Extensions_CardinalDirection
    {
        static public CardinalDirection GetClosestCardinalDirection(this VectorF2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestCardinalDirection();
        }
    }
}