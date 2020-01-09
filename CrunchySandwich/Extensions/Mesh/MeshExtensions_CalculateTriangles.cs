using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class MeshExtensions_CalculateTriangles
    {
        static public void CalculateTrianglesAsSequential(this Mesh item)
        {
            item.triangles = Ints.Range(0, item.vertexCount, false)
                .ToArray();
        }

        static public void CalculateTrianglesAsFan(this Mesh item)
        {
            item.triangles = Ints.Range(1, item.vertexCount, false)
                .ConvertConnections((p1, p2) => Enumerable.New(0, p2, p1))
                .ToArray();
        }

        static public void CalculateTrianglesAsSequentialQuads(this Mesh item)
        {
            item.triangles = Ints.Range(0, item.vertexCount, 4, false)
                .Convert(i => Enumerable.New(i, i+1, i+2, i, i+2, i+3))
                .ToArray();
        }
    }
}