using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle3Extensions
    {
        static public Triangle3 CreatePoints(IEnumerable<Vector3> points)
        {
            Vector3 v0, v1, v2;

            points.PartOut(out v0, out v1, out v2);
            return new Triangle3(v0, v1, v2);
        }
    }
}