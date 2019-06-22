using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Compare
    {
        static public bool IsZero(this Vector2 item)
        {
            if (item.x == 0.0f && item.y == 0.0f)
                return true;

            return false;
        }

        static public bool IsNonZero(this Vector2 item)
        {
            if (item.IsZero() == false)
                return true;

            return false;
        }
    }
}