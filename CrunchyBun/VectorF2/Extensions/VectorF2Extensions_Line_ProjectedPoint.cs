using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Line_ProjectedPoint
    {
        static public VectorF2 GetProjectedPointOntoLine(this VectorF2 item, VectorF2 target, VectorF2 point)
        {
            VectorF2 direction = item.GetDirection(target);

            return direction * direction.GetDot(point - item) + item;
        }

        static public VectorF2 GetProjectedPointOntoLineSegment(this VectorF2 item, VectorF2 target, VectorF2 point)
        {
            VectorF2 direction = item.GetDirection(target);

            float point_projection = direction.GetDot(point - item);

            float item_projection = 0.0f;
            float target_projection = direction.GetDot(target - item);

            return direction * point_projection.BindBetween(item_projection, target_projection) + item;
        }
    }
}