using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Vector2Extensions_MinMax
    {
        static public Vector2 GetMin(this Vector2 item, Vector2 input)
        {
            return new Vector2(item.x.Min(input.x), item.y.Min(input.y));
        }

        static public Vector2 GetMax(this Vector2 item, Vector2 input)
        {
            return new Vector2(item.x.Max(input.x), item.y.Max(input.y));
        }

        static public void Order(this Vector2 item, Vector2 input, out Vector2 lower, out Vector2 upper)
        {
            float x_min;
            float x_max;
            item.x.Order(input.x, out x_min, out x_max);

            float y_min;
            float y_max;
            item.y.Order(input.y, out y_min, out y_max);

            lower = new Vector2(x_min, y_min);
            upper = new Vector2(x_max, y_max);
        }
    }
}