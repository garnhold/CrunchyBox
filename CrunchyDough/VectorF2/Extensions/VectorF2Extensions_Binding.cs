using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class VectorF2Extensions_Binding
    {
        static public VectorF2 BindAbove(this VectorF2 item, VectorF2 lower)
        {
            return new VectorF2(item.x.BindAbove(lower.x), item.y.BindAbove(lower.y));
        }

        static public VectorF2 BindBelow(this VectorF2 item, VectorF2 upper)
        {
            return new VectorF2(item.x.BindBelow(upper.x), item.y.BindBelow(upper.y));
        }

        static public VectorF2 BindBetween(this VectorF2 item, VectorF2 value1, VectorF2 value2)
        {
            return new VectorF2(item.x.BindBetween(value1.x, value2.x), item.y.BindBetween(value1.y, value2.y));
        }

        static public VectorF2 BindAround(this VectorF2 item, float radius)
        {
            float distance;
            VectorF2 direction = item.GetNormalized(out distance);

            if (distance > radius)
                return direction * radius;

            return item;
        }
        static public VectorF2 BindAround(this VectorF2 item, VectorF2 center, float radius)
        {
            return center + (item - center).BindAround(radius);
        }
    }
}