using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Bounds
    {
        static public Bounds GetBounds(this Quad2 item)
        {
            return BoundsExtensions.CreateWithPoints(item.GetPoints().GetSpacar());
        }
    }
}