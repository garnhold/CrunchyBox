using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorI2Extensions_IsBound
    {
        static public bool IsBoundAbove(this VectorI2 item, VectorI2 value)
        {
            if (item.x >= value.x && item.y >= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBelow(this VectorI2 item, VectorI2 value)
        {
            if (item.x <= value.x && item.y <= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBetween(this VectorI2 item, VectorI2 value1, VectorI2 value2)
        {
            VectorI2 lower;
            VectorI2 upper;

            value1.Order(value2, out lower, out upper);

            if (item.IsBoundAbove(lower) && item.IsBoundBelow(upper))
                return true;

            return false;
        }
    }
}