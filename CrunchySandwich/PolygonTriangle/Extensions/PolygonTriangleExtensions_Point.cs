using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class PolygonTriangleExtensions_Point
    {
        static public bool Contains(this PolygonTriangle item, Vector2 point, float tolerance = 0.0f)
        {
            if (
                item.f1.IsInside(point, tolerance) &&
                item.f2.IsInside(point, tolerance) &&
                item.f3.IsInside(point, tolerance)
            )
            {
                return true;
            }

            return false;
        }
    }
}