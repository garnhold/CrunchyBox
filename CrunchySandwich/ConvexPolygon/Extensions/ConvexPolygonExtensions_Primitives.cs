using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class ConvexPolygonExtensions_Primitives
    {
        static public IEnumerable<Vector2> GetVertexs(this ConvexPolygon item)
        {
            return item.GetFaces().Convert(f => f.v0);
        }

        static public IEnumerable<Vector2> GetNormals(this ConvexPolygon item)
        {
            return item.GetFaces().Convert(f => f.normal);
        }
    }
}