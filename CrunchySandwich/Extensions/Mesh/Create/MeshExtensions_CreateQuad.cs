using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class MeshExtensions
    {
        static public Mesh CreateQuad(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
        {
            Mesh mesh = CreateNullQuad();

            mesh.vertices = new Vector3[]{ p1, p2, p3, p4 };
            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            return mesh;
        }
        static public Mesh CreateQuad(Rect rect)
        {
            return CreateQuad(
                rect.GetLowerLeftPoint(),
                rect.GetUpperLeftPoint(),
                rect.GetUpperRightPoint(),
                rect.GetLowerRightPoint()
            );
        }
    }
}