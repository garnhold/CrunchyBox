using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class ConvexPolygonExtensions_Point
    {
        static public bool IsPointWithin(this ConvexPolygon item, Vector2 point, float tolerance = 0.0f)
        {
            if (item.GetFaces().AreAll(f => f.IsInside(point, tolerance)))
                return true;

            return false;
        }
    }
}