using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class MeshBuilder
    {
        private List<int> triangles;
        private Palette<Vector3> vertexs;

        public MeshBuilder()
        {
            triangles = new List<int>();
            vertexs = new Palette<Vector3>();
        }

        public void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            int index0, index1, index2;

            if (v0 != v1 && v1 != v2 && v2 != v0)
            {
                vertexs.TryAdd(v0, out index0);
                vertexs.TryAdd(v1, out index1);
                vertexs.TryAdd(v2, out index2);

                triangles.Add(index0);
                triangles.Add(index1);
                triangles.Add(index2);
            }
        }

        public void AddQuad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
        {
            AddTriangle(v0, v1, v2);
            AddTriangle(v2, v3, v0);
        }

        public void AddTriangleFan(IList<Vector3> vertex_loop)
        {
            Vector3 center = vertex_loop.Average();

            vertex_loop.CloseLoop().ProcessConnections((v0, v1) => AddTriangle(v0, v1, center));
        }

        public void AddConvexPolygon(IList<Vector3> vertex_loop)
        {
            if (vertex_loop.Count >= 3)
            {
                if (vertex_loop.Count == 3)
                    AddTriangle(vertex_loop[0], vertex_loop[1], vertex_loop[2]);
                else if (vertex_loop.Count == 4)
                    AddQuad(vertex_loop[0], vertex_loop[1], vertex_loop[2], vertex_loop[3]);
                else
                    AddTriangleFan(vertex_loop);
            }
        }

        public void AddConvexPolygon(IEnumerable<Vector3> v)
        {
            AddConvexPolygon(v.ToList());
        }

        public Mesh BuildMesh()
        {
            Mesh mesh = new Mesh();

            mesh.vertices = vertexs.GetValues().ToArray();
            mesh.triangles = triangles.ToArray();

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            return mesh;
        }

        public IEnumerable<Triangle3> GetTriangles()
        {
            return vertexs.AtIndexs(triangles)
                .ChunkStrict(3)
                .Convert(i => Triangle3Extensions.CreatePoints(i));
        }
    }
}