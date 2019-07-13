using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_CardinalOrdinalDirection
    {
        static public CardinalOrdinalDirection GetClosestCardinalOrdinalDirection(this Vector2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestCardinalOrdinalDirection();
        }
    }
}