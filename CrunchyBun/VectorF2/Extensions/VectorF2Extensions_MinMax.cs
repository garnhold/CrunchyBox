using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyBun;

namespace CrunchyBun
{
    static public class VectorF2Extensions_MinMax
    {
        static public VectorF2 GetMin(this VectorF2 item, VectorF2 input)
        {
            return new VectorF2(item.x.Min(input.x), item.y.Min(input.y));
        }

        static public VectorF2 GetMax(this VectorF2 item, VectorF2 input)
        {
            return new VectorF2(item.x.Max(input.x), item.y.Max(input.y));
        }

        static public void Order(this VectorF2 item, VectorF2 input, out VectorF2 lower, out VectorF2 upper)
        {
            float x_min;
            float x_max;
            item.x.Order(input.x, out x_min, out x_max);

            float y_min;
            float y_max;
            item.y.Order(input.y, out y_min, out y_max);

            lower = new VectorF2(x_min, y_min);
            upper = new VectorF2(x_max, y_max);
        }
    }
}