using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle2Extensions
    {
        static public Triangle2 CreatePoints(IEnumerable<Vector2> points)
        {
            Vector2 v0, v1, v2;

            points.PartOut(out v0, out v1, out v2);
            return new Triangle2(v0, v1, v2);
        }
    }
}