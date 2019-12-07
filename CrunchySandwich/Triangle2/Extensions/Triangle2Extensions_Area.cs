using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle2Extensions_Area
    {
        static public float GetArea(this Triangle2 item)
        {
            return item.GetPoints().GetLoopArea();
        }
    }
}