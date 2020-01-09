using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle2Extensions_Rect
    {
        static public Rect GetRect(this Triangle2 item)
        {
            return RectExtensions.CreatePoints(item.GetPoints());
        }
    }
}