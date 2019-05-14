using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Axis
    {
        static public float GetComponent(this Vector2 item, Axis axis)
        {
            switch (axis)
            {
                case Axis.X: return item.x;
                case Axis.Y: return item.y;
            }

            return 0.0f;
        }
    }
}