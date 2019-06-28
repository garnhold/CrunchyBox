using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Invert
    {
        static public Vector2 GetInvertX(this Vector2 item)
        {
            return new Vector2(-item.x, item.y);
        }

        static public Vector2 GetInvertY(this Vector2 item)
        {
            return new Vector2(item.x, -item.y);
        }
    }
}