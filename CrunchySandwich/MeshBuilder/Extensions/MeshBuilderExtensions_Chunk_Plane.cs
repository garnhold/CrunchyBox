using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class MeshBuilderExtensions_Chunk_Plane
    {
        static public void AddChunk(this MeshBuilder item, IEnumerable<Triangle3> triangles, Plane plane)
        {
            item.AddConvexPolygons(
                triangles.ConvertGrouped(t => plane.GetTriangleIntersection(t))
            );
        }

        static public void AddChunk(this MeshBuilder item, Mesh mesh, Plane plane)
        {
            item.AddChunk(mesh.GetTriangles(), plane);
        }

        static public void AddChunk(this MeshBuilder item, MeshDissector mesh_dissector, Plane plane)
        {
            item.AddChunk(mesh_dissector.GetTrianglesWithin(plane), plane);
        }
    }
}