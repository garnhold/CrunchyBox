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

        static public Vector2 GetWithY(this Vector2 item, float y)
        {
            return new Vector2(item.x, y);
        }
    }
}