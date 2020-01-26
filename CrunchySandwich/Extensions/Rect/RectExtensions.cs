using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions
    {
        static private readonly Rect ZERO_RECT = new Rect(0.0f, 0.0f, 0.0f, 0.0f);

        static public bool TryCreateStrictMinMaxRect(float x_min, float y_min, float x_max, float y_max, out Rect rect)
        {
            if (x_min < x_max)
            {
                if (y_min < y_max)
                {
                    rect = Rect.MinMaxRect(x_min, y_min, x_max, y_max);
                    return true;
                }
            }

            rect = ZERO_RECT;
            return false;
        }
        static public Rect CreateStrictMinMaxRect(float x_min, float y_min, float x_max, float y_max)
        {
            Rect rect;

            TryCreateStrictMinMaxRect(x_min, y_min, x_max, y_max, out rect);
            return rect;
        }
        static public Rect CreateStrictMinMaxRect(Vector2 min, Vector2 max)
        {
            return CreateStrictMinMaxRect(min.x, min.y, max.x, max.y);
        }

        static public Rect CreateMinMaxRect(float x_min, float y_min, float x_max, float y_max)
        {
            x_min.Order(x_max, out x_min, out x_max);
            y_min.Order(y_max, out y_min, out y_max);

            return Rect.MinMaxRect(x_min, y_min, x_max, y_max);
        }
        static public Rect CreateMinMaxRect(Vector2 min, Vector2 max)
        {
            return CreateMinMaxRect(min.x, min.y, max.x, max.y);
        }

        static public Rect CreateCenterRect(float x, float y, float width, float height)
        {
            return new Rect(x - width * 0.5f, y - height * 0.5f, width, height);
        }
        static public Rect CreateCenterRect(Vector2 position, Vector2 size)
        {
            return CreateCenterRect(position.x, position.y, size.x, size.y);
        }

        static public Rect CreatePoints(IEnumerable<Vector2> points)
        {
            return CreateMinMaxRect(points.Min(), points.Max());
        }
    }
}