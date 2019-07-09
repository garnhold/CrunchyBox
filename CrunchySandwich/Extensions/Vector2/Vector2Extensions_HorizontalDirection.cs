using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_HorizontalDirection
    {
        static public HorizontalDirection GetClosestHorizontalDirection(this Vector2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestHorizontalDirection();
        }
    }
}