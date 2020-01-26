using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_Shift
    {
        static public Rect GetShifted(this Rect item, Vector2 amount)
        {
            item.position += amount;

            return item;
        }
    }
}