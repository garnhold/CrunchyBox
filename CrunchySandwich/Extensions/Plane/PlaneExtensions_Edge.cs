using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneExtensions_Edge
    {
        static public bool IsCoplanar(this Plane item, Edge3 edge, float tolerance = 0.0f)
        {
            if (item.AreCoplanar(edge.GetPoints(), tolerance))
                return true;

            return false;
        }
    }
}