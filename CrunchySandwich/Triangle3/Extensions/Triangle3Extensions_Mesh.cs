using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_Mesh
    {
        static public Mesh MakeFlatMesh(this IEnumerable<Triangle3> item)
        {
            Mesh mesh = new Mesh();

            mesh.vertices = item.Convert(t => t.GetPoints()).ToArray();
            mesh.triangles = Ints.Range(0, mesh.vertexCount, false).ToArray();

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            return mesh;
        }
    }
}