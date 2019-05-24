using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class MeshBuilder
    {
        public abstract ICatalog<int> GetIndexs();
        public abstract ICatalog<Vector3> GetVertexs();

        public abstract void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2);

        public Mesh BuildMesh()
        {
            Mesh mesh = new Mesh();

            mesh.vertices = GetVertexs().ToArray();
            mesh.triangles = GetIndexs().ToArray();

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            return mesh;
        }

        public IEnumerable<Triangle3> GetTriangles()
        {
            return GetVertexs().AtIndexs(GetIndexs())
                .ChunkStrict(3)
                .Convert(i => Triangle3Extensions.CreatePoints(i));
        }
    }
}