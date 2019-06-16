using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Bounds
    {
        static public Bounds GetBounds(this Vector2 item)
        {
            return new Bounds(item, Vector2.zero);
        }
    }
}