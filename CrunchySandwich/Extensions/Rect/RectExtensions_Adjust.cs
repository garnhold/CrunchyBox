using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_Adjust
    {
        static public Rect GetAdjusted(this Rect item, float x_min_adjust, float y_min_adjust, float x_max_adjust, float y_max_adjust)
        {
            return RectExtensions.CreateStrictMinMaxRect(item.xMin + x_min_adjust, item.yMin + y_min_adjust, item.xMax + x_max_adjust, item.yMax + y_max_adjust);
        }

        static public Rect GetEnlarged(this Rect item, float x_min_adjust, float y_min_adjust, float x_max_adjust, float y_max_adjust)
        {
            return item.GetAdjusted(-x_min_adjust, -y_min_adjust, x_max_adjust, y_max_adjust);
        }
        static public Rect GetEnlarged(this Rect item, float x, float y)
        {
            return item.GetEnlarged(x, y, x, y);
        }
        static public Rect GetEnlarged(this Rect item, Vector2 amount)
        {
            return item.GetEnlarged(amount.x, amount.y);
        }
        static public Rect GetEnlarged(this Rect item, float amount)
        {
            return item.GetEnlarged(amount, amount);
        }

        static public Rect GetShrunk(this Rect item, float x_min_adjust, float y_min_adjust, float x_max_adjust, float y_max_adjust)
        {
            return item.GetEnlarged(-x_min_adjust, -y_min_adjust, -x_max_adjust, -y_max_adjust);
        }
        static public Rect GetShrunk(this Rect item, float x, float y)
        {
            return item.GetShrunk(x, y, x, y);
        }
        static public Rect GetShrunk(this Rect item, Vector2 amount)
        {
            return item.GetShrunk(amount.x, amount.y);
        }
        static public Rect GetShrunk(this Rect item, float amount)
        {
            return item.GetShrunk(amount, amount);
        }
    }
}