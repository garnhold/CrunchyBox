using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class MeshBuilderExtensions_Build
    {
        static public Mesh BuildMesh(this MeshBuilder item)
        {
            Mesh mesh = new Mesh();

            mesh.vertices = item.GetVertexs().ToArray();
            mesh.triangles = item.GetIndexs().ToArray();

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            return mesh;
        }

        static public Mesh BuildFlatMesh(this MeshBuilder item)
        {
            Mesh mesh = new Mesh();
            Vector3[] vertexs = item.GetVertexs().AtIndexs(item.GetIndexs()).ToArray();

            mesh.vertices = vertexs;
            mesh.triangles = Ints.Range(0, vertexs.Length, false).ToArray();

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            return mesh;
        }
    }
}