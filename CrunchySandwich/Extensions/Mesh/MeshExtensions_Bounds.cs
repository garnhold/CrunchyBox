using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class MeshExtensions_Bounds
    {
        static public IEnumerable<Vector3> GetVertexsWithin(this Mesh item, Bounds bounds)
        {
            return item.vertices
                .Narrow(v => bounds.Contains(v));
        }
    }
}