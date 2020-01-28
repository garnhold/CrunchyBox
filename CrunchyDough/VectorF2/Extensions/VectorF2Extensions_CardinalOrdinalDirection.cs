using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_CardinalOrdinalDirection
    {
        static public CardinalOrdinalDirection GetClosestCardinalOrdinalDirection(this VectorF2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestCardinalOrdinalDirection();
        }
    }
}