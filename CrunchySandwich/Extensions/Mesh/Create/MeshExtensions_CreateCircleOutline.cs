using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class MeshExtensions
    {
        static public Mesh CreateCircleOutline(float width, int number_vertexs)
        {
            Mesh mesh = new Mesh();

            int ring_vertexs = number_vertexs / 2;

            mesh.vertices = Floats.Line(0.0f, 360.0f, ring_vertexs, true)
                .Convert(a => Vector2Extensions.CreateDirectionFromDegrees(a).GetSpacar() * 0.5f)
                .Append(
                    Floats.Line(0.0f, 360.0f, ring_vertexs, true)
                        .Convert(a => Vector2Extensions.CreateDirectionFromDegrees(a).GetSpacar() * (0.5f - width))
                )
                .ToArray();

            mesh.triangles = Ints.Range(0, ring_vertexs, false)
                .ConvertConnections((p1, p2) => 
                    Enumerable.New(
                        p1 + ring_vertexs, p2, p1,
                        p1 + ring_vertexs, p2 + ring_vertexs, p2
                    )
                )
                .ToArray();

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            return mesh;
        }
    }
}