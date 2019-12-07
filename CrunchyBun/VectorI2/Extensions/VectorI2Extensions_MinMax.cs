using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    using Bun;
    
    static public class VectorI2Extensions_MinMax
    {
        static public VectorI2 GetMin(this VectorI2 item, VectorI2 input)
        {
            return new VectorI2(item.x.Min(input.x), item.y.Max(input.y));
        }

        static public VectorI2 GetMax(this VectorI2 item, VectorI2 input)
        {
            return new VectorI2(item.x.Max(input.x), item.y.Max(input.y));
        }

        static public void Order(this VectorI2 item, VectorI2 input, out VectorI2 lower, out VectorI2 upper)
        {
            int x_min;
            int x_max;
            item.x.Order(input.x, out x_min, out x_max);

            int y_min;
            int y_max;
            item.y.Order(input.y, out y_min, out y_max);

            lower = new VectorI2(x_min, y_min);
            upper = new VectorI2(x_max, y_max);
        }
    }
}