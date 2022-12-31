using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Area
    {
        static public float GetArea(this Quad2 item)
        {
            return item.GetPoints().GetLoopArea();
        }
    }
}