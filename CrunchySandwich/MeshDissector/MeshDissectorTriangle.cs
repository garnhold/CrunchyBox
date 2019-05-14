using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public struct MeshDissectorTriangle
    {
        public readonly Triangle3 triangle;
        public readonly Bounds bounds;

        public MeshDissectorTriangle(Triangle3 t)
        {
            triangle = t;
            bounds = t.GetBounds();
        }
    }
}