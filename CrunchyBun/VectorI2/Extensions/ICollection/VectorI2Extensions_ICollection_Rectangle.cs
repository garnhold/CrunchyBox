using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    using Bun;
    
    static public class VectorI2Extensions_ICollection_Rectangle
    {
        static public void AddRectangle(this ICollection<VectorI2> item, VectorI2 point1, VectorI2 point2)
        {
            VectorI2 lower;
            VectorI2 upper;

            point1.Order(point2, out lower, out upper);

            for (int x = lower.x; x <= upper.x; x++)
            {
                for (int y = lower.y; y <= upper.y; y++)
                    item.Add(new VectorI2(x, y));
            }
        }
    }
}