using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class MeshDissector
    {
        private BoundsTree<MeshDissectorTriangle> triangles;

        public MeshDissector(Mesh mesh, int depth, int target_number_triangles)
        {
            triangles = BoundsTree<MeshDissectorTriangle>.CreateOctree(
                mesh.bounds.GetEnlarged(0.1f),
                depth,
                target_number_triangles,
                t => t.bounds,
                mesh.GetTriangles().Convert(t => new MeshDissectorTriangle(t))
            );
        }

        public MeshDissector(Mesh mesh) : this(mesh, 5, 45) { }

        public IEnumerable<Triangle3> GetTrianglesWithin(Bounds bounds)
        {
            return triangles.GetItemsWithin(bounds).Convert(t => t.triangle);
        }

        public IEnumerable<Triangle3> GetTrianglesWithin(Plane plane)
        {
            return triangles.GetItemsWithin(plane).Convert(t => t.triangle);
        }

        public IEnumerable<Triangle3> GetTriangles()
        {
            return triangles.Convert(t => t.triangle);
        }
    }
}