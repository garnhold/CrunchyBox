using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class MeshBuilderExtensions_PolygonTriangle
    {
        static public void AddTriangle(this MeshBuilder item, PolygonTriangle triangle)
        {
            item.AddTriangle(triangle.triangle);
        }

        static public void AddTriangles(this MeshBuilder item, IEnumerable<PolygonTriangle> triangles)
        {
            triangles.Process(t => item.AddTriangle(t));
        }
        static public void AddTriangles(this MeshBuilder item, params PolygonTriangle[] triangles)
        {
            item.AddTriangles((IEnumerable<PolygonTriangle>)triangles);
        }
    }
}