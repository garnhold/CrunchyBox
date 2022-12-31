using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Shift
    {
        static public Quad2 GetShifted(this Quad2 item, Vector2 amount)
        {
            return new Quad2(
                item.v0 + amount,
                item.v1 + amount,
                item.v2 + amount,
                item.v3 + amount
            );
        }
    }
}