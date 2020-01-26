using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsExtensions_Intersection_Bounds
    {
        static public bool IsIntersecting(this Bounds item, Bounds other)
        {
            if (item.Intersects(other))
                return true;

            return false;
        }
    }
}