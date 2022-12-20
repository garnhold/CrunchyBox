using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class VectorF2Extensions_With
    {
        static public VectorF2 GetWithX(this VectorF2 item, float x)
        {
            return new VectorF2(x, item.y);
        }

        static public VectorF2 GetWithFlippedX(this VectorF2 item)
        {
            return item.GetWithX(-item.x);
        }

        static public VectorF2 GetWithAdjustedX(this VectorF2 item, float amount)
        {
            return item.GetWithX(item.x + amount);
        }

        static public VectorF2 GetWithScaledX(this VectorF2 item, float scale)
        {
            return item.GetWithX(item.x * scale);
        }

        static public VectorF2 GetWithBoundX(this VectorF2 item, float a, float b)
        {
            return item.GetWithX(item.x.BindBetween(a, b));
        }
        static public VectorF2 GetWithBoundX(this VectorF2 item, FloatRange range)
        {
            return item.GetWithBoundX(range.x1, range.x2);
        }

        static public VectorF2 GetWithY(this VectorF2 item, float y)
        {
            return new VectorF2(item.x, y);
        }

        static public VectorF2 GetWithFlippedY(this VectorF2 item)
        {
            return item.GetWithY(-item.y);
        }

        static public VectorF2 GetWithAdjustedY(this VectorF2 item, float amount)
        {
            return item.GetWithY(item.y + amount);
        }

        static public VectorF2 GetWithScaledY(this VectorF2 item, float scale)
        {
            return item.GetWithY(item.y * scale);
        }

        static public VectorF2 GetWithBoundY(this VectorF2 item, float a, float b)
        {
            return item.GetWithY(item.y.BindBetween(a, b));
        }
        static public VectorF2 GetWithBoundY(this VectorF2 item, FloatRange range)
        {
            return item.GetWithBoundY(range.x1, range.x2);
        }
    }
}