using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class MeshBuilderExtensions_Triangle3
    {
        static public void AddTriangle(this MeshBuilder item, Triangle3 triangle)
        {
            item.AddTriangle(triangle.v0, triangle.v1, triangle.v2);
        }

        static public void AddTriangles(this MeshBuilder item, IEnumerable<Triangle3> triangles)
        {
            triangles.Process(t => item.AddTriangle(t));
        }
        static public void AddTriangles(this MeshBuilder item, params Triangle3[] triangles)
        {
            item.AddTriangles((IEnumerable<Triangle3>)triangles);
        }
    }
}