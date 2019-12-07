using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class MeshBuilderExtensions_TriangleFan
    {
        static public void AddTriangleFan(this MeshBuilder item, IList<Vector3> vertex_loop)
        {
            Vector3 center = vertex_loop.Average();

            vertex_loop.CloseLoop().ProcessConnections((v0, v1) => item.AddTriangle(v0, v1, center));
        }
    }
}