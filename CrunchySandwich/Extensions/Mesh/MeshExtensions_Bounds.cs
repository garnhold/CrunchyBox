using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
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