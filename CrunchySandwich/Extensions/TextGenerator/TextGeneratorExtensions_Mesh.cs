using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TextGeneratorExtensions_Mesh
    {
        static public Mesh CreateMesh(this TextGenerator item)
        {
            Mesh mesh = new Mesh();

            mesh.vertices = item.verts.Convert(v => v.position).ToArray();
            mesh.normals = item.verts.Convert(v => v.normal).ToArray();
            mesh.tangents = item.verts.Convert(v => v.tangent).ToArray();

            mesh.uv = item.verts.Convert(v => v.uv0).ToArray();
            mesh.colors32 = item.verts.Convert(v => v.color).ToArray();

            mesh.CalculateTrianglesAsSequentialQuads();
            return mesh;
        }
    }
}