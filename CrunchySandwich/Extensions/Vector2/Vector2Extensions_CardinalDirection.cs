using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_CardinalDirection
    {
        static public CardinalDirection GetClosestCardinalDirection(this Vector2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestCardinalDirection();
        }
    }
}