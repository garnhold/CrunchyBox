using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle2Extensions_Shift
    {
        static public Triangle2 GetShifted(this Triangle2 item, Vector2 amount)
        {
            return new Triangle2(
                item.v0 + amount,
                item.v1 + amount,
                item.v2 + amount
            );
        }
    }
}