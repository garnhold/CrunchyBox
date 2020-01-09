using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions_IsBound
    {
        static public bool IsBoundAbove(this VectorF2 item, VectorF2 value)
        {
            if (item.x >= value.x && item.y >= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBelow(this VectorF2 item, VectorF2 value)
        {
            if (item.x <= value.x && item.y <= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBetween(this VectorF2 item, VectorF2 value1, VectorF2 value2)
        {
            VectorF2 lower;
            VectorF2 upper;

            value1.Order(value2, out lower, out upper);

            if (item.IsBoundAbove(lower) && item.IsBoundBelow(upper))
                return true;

            return false;
        }
    }
}