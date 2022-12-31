using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Rect
    {
        static public Rect GetRect(this Quad2 item)
        {
            return RectExtensions.CreatePoints(item.GetPoints());
        }
    }
}