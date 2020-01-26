using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Binding
    {
        static public Vector2 BindAbove(this Vector2 item, Vector2 lower)
        {
            return new Vector2(item.x.BindAbove(lower.x), item.y.BindAbove(lower.y));
        }

        static public Vector2 BindBelow(this Vector2 item, Vector2 upper)
        {
            return new Vector2(item.x.BindBelow(upper.x), item.y.BindBelow(upper.y));
        }

        static public Vector2 BindBetween(this Vector2 item, Vector2 value1, Vector2 value2)
        {
            return new Vector2(item.x.BindBetween(value1.x, value2.x), item.y.BindBetween(value1.y, value2.y));
        }

        static public Vector2 BindWithin(this Vector2 item, Rect rect)
        {
            return item.BindBetween(rect.min, rect.max);
        }

        static public Vector2 BindAround(this Vector2 item, float radius)
        {
            float distance;
            Vector2 direction = item.GetNormalized(out distance);

            if (distance > radius)
                return direction * radius;

            return item;
        }
        static public Vector2 BindAround(this Vector2 item, Vector2 center, float radius)
        {
            return center + (item - center).BindAround(radius);
        }
    }
}