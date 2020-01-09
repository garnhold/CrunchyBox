using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class MeshExtensions
    {
        static public Mesh CreateNullQuad()
        {
            Mesh mesh = new Mesh();

            mesh.vertices = new Vector3[4];

            mesh.triangles = new int[]{
                0, 1, 2,
                2, 3, 0
            };

            mesh.uv = new Vector2[]{
                new Vector2(0.0f, 0.0f),
                new Vector2(0.0f, 1.0f),
                new Vector2(1.0f, 1.0f),
                new Vector2(1.0f, 0.0f)
            };

            mesh.normals = new Vector3[]{
                new Vector3(0.0f, 0.0f, -1.0f),
                new Vector3(0.0f, 0.0f, -1.0f),
                new Vector3(0.0f, 0.0f, -1.0f),
                new Vector3(0.0f, 0.0f, -1.0f)
            };

            return mesh;
        }
    }
}