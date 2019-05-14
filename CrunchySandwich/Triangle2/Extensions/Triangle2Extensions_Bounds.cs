using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle2Extensions_Bounds
    {
        static public Bounds GetBounds(this Triangle2 item)
        {
            return BoundsExtensions.CreateWithPoints(item.GetPoints().GetSpacar());
        }
    }
}