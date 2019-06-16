using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PolygonTriangle
    {
        public readonly Triangle2 triangle;

        public readonly Face f1;
        public readonly Face f2;
        public readonly Face f3;

        public PolygonTriangle(Triangle2 t)
        {
            triangle = t;

            f1 = triangle.GetEdge01().GetFace();
            f2 = triangle.GetEdge12().GetFace();
            f3 = triangle.GetEdge20().GetFace();
        }
    }
}