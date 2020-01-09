using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions_CardinalDirection
    {
        static public CardinalDirection GetClosestCardinalDirection(this VectorF2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestCardinalDirection();
        }
    }
}