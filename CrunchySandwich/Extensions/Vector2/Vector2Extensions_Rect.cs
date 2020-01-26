using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_Rect
    {
        static public Rect GetRect(this Vector2 item)
        {
            return new Rect(item, Vector2.zero);
        }
    }
}