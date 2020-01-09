using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Vector2Extensions_Abs
    {
        static public Vector2 GetAbs(this Vector2 item)
        {
            return new Vector2(item.x.GetAbs(), item.y.GetAbs());
        }
    }
}