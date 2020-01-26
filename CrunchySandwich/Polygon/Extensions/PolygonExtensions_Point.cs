using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class PolygonExtensions_Point
    {
        static public bool IsPointWithin(this Polygon item, Vector2 point)
        {
            if (item.GetTriangles().Has(t => t.Contains(point)))
                return true;

            return false;
        }
    }
}