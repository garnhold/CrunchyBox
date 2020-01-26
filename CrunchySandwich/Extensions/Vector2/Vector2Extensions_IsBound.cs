using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_IsBound
    {
        static public bool IsBoundAbove(this Vector2 item, Vector2 value)
        {
            if (item.x >= value.x && item.y >= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBelow(this Vector2 item, Vector2 value)
        {
            if (item.x <= value.x && item.y <= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBetween(this Vector2 item, Vector2 value1, Vector2 value2)
        {
            Vector2 lower;
            Vector2 upper;

            value1.Order(value2, out lower, out upper);

            if (item.IsBoundAbove(lower) && item.IsBoundBelow(upper))
                return true;

            return false;
        }
    }
}