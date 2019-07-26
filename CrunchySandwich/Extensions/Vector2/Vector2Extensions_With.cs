using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_With
    {
        static public Vector2 GetWithX(this Vector2 item, float x)
        {
            return new Vector2(x, item.y);
        }

        static public Vector2 GetWithFlippedX(this Vector2 item)
        {
            return item.GetWithX(-item.x);
        }

        static public Vector2 GetWithAdjustedX(this Vector2 item, float amount)
        {
            return item.GetWithX(item.x + amount);
        }

        static public Vector2 GetWithY(this Vector2 item, float y)
        {
            return new Vector2(item.x, y);
        }

        static public Vector2 GetWithFlippedY(this Vector2 item)
        {
            return item.GetWithY(-item.y);
        }

        static public Vector2 GetWithAdjustedY(this Vector2 item, float amount)
        {
            return item.GetWithY(item.y + amount);
        }
    }
}