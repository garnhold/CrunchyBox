using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class MeshBuilderExtensions_Triangle2
    {
        static public void AddTriangle(this MeshBuilder item, Triangle2 triangle)
        {
            item.AddTriangle(triangle.v0, triangle.v1, triangle.v2);
        }

        static public void AddTriangles(this MeshBuilder item, IEnumerable<Triangle2> triangles)
        {
            triangles.Process(t => item.AddTriangle(t));
        }
        static public void AddTriangles(this MeshBuilder item, params Triangle2[] triangles)
        {
            item.AddTriangles((IEnumerable<Triangle2>)triangles);
        }
    }
}