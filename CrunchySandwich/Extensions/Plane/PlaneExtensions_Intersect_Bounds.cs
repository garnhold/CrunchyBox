using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_Intersect_Bounds
    {
        static public bool IsIntersecting(this Plane item, Bounds bounds)
        {
            if (bounds.GetPoints().Has(v => item.IsInside(v)))
                return true;

            return false;
        }
    }
}