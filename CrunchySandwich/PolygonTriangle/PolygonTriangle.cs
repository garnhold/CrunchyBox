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

            f1 = FaceExtensions.CreatePoints(triangle.v0, triangle.v1);
            f2 = FaceExtensions.CreatePoints(triangle.v1, triangle.v2);
            f3 = FaceExtensions.CreatePoints(triangle.v2, triangle.v0);
        }
    }
}