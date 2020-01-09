using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Dot
    {
        static public float GetDot(this Vector2 item, Vector2 other)
        {
            return Vector2.Dot(item, other);
        }
    }
}