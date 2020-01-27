using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class VectorI2Extensions_With
    {
        static public VectorI2 GetWithX(this VectorI2 item, int x)
        {
            return new VectorI2(x, item.y);
        }

        static public VectorI2 GetWithFlippedX(this VectorI2 item)
        {
            return item.GetWithX(-item.x);
        }

        static public VectorI2 GetWithAdjustedX(this VectorI2 item, int amount)
        {
            return item.GetWithX(item.x + amount);
        }

        static public VectorI2 GetWithY(this VectorI2 item, int y)
        {
            return new VectorI2(item.x, y);
        }

        static public VectorI2 GetWithFlippedY(this VectorI2 item)
        {
            return item.GetWithY(-item.y);
        }

        static public VectorI2 GetWithAdjustedY(this VectorI2 item, int amount)
        {
            return item.GetWithY(item.y + amount);
        }
    }
}