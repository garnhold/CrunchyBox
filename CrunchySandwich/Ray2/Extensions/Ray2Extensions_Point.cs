using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Ray2Extensions_Point
    {
        static public Vector2 GetPointAlong(this Ray2 item, float distance)
        {
            return item.origin + item.direction * distance;
        }
    }
}