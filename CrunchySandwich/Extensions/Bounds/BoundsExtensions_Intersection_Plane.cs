using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
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