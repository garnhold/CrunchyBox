using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_Intersection_Plane
    {
        static public bool IsIntersecting(this Bounds item, Plane plane)
        {
            if (plane.IsIntersecting(item))
                return true;

            return false;
        }
    }
}