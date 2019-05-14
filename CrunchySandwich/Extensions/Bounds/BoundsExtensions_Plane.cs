using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class BoundsExtensions_Plane
    {
        static public bool IntersectsPlane(this Bounds item, Plane plane)
        {
            if (plane.IntersectsBounds(item))
                return true;

            return false;
        }
    }
}