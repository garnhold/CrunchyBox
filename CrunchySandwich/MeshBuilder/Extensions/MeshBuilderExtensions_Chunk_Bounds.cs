using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class MeshBuilderExtensions_Chunk_Bounds
    {
        static public void AddChunk(this MeshBuilder item, IEnumerable<Triangle3> triangles, Bounds bounds)
        {
            item.AddConvexPolygons(
                triangles.Convert(t => bounds.GetTriangleIntersection(t))
            );
        }

        static public void AddChunk(this MeshBuilder item, Mesh mesh, Bounds bounds)
        {
            item.AddChunk(mesh.GetTriangles(), bounds);
        }

        static public void AddChunk(this MeshBuilder item, MeshDissector mesh_dissector, Bounds bounds)
        {
            item.AddChunk(mesh_dissector.GetTrianglesWithin(bounds), bounds);
        }
    }
}