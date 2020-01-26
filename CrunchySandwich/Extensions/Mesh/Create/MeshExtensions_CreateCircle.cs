using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;

    static public partial class MeshExtensions
    {
        static public Mesh CreateCircle(int number_vertexs)
        {
            Mesh mesh = new Mesh();

            mesh.vertices = Floats.Line(0.0f, 360.0f, number_vertexs - 1, true)
                .Convert(a => Vector2Extensions.CreateDirectionFromDegrees(a).GetSpacar() * 0.5f)
                .Prepend(new Vector3(0.0f, 0.0f, 0.0f))
                .ToArray();
                
            mesh.CalculateTrianglesAsFan();

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            return mesh;
        }
    }
}