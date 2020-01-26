using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Line_ProjectedPoint
    {
        static public Vector2 GetProjectedPointOntoLine(this Vector2 item, Vector2 target, Vector2 point)
        {
            Vector2 direction = item.GetDirection(target);

            return direction * direction.GetDot(point - item) + item;
        }

        static public Vector2 GetProjectedPointOntoLineSegment(this Vector2 item, Vector2 target, Vector2 point)
        {
            Vector2 direction = item.GetDirection(target);

            float point_projection = direction.GetDot(point - item);

            float item_projection = 0.0f;
            float target_projection = direction.GetDot(target - item);

            return direction * point_projection.BindBetween(item_projection, target_projection) + item;
        }
    }
}