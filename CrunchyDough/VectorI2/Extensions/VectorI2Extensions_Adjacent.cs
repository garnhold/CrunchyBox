using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class VectorI2Extensions_Adjacent
    {
        static public bool IsCardinallyAdjacent(this VectorI2 item, VectorI2 other)
        {
            if (item.x == other.x)
            {
                if (item.y == other.y - 1)
                    return true;

                if (item.y == other.y + 1)
                    return true;
            }

            if (item.y == other.y)
            {
                if (item.x == other.x - 1)
                    return true;

                if (item.x == other.x + 1)
                    return true;
            }

            return false;
        }

        static public bool IsOrdinallyAdjacent(this VectorI2 item, VectorI2 other)
        {
            if (item.x == other.x - 1 || item.x == other.x + 1)
            {
                if (item.y == other.y - 1)
                    return true;

                if (item.y == other.y + 1)
                    return true;
            }

            return false;
        }

        static public bool IsCardinallyOrOrdinallyAdjacent(this VectorI2 item, VectorI2 other)
        {
            if (item.IsCardinallyAdjacent(other) || item.IsOrdinallyAdjacent(other))
                return true;

            return false;
        }
    }
}