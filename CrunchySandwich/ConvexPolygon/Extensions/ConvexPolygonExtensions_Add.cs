using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class ConvexPolygonExtensions_Add
    {
        static public void AddVertexs(this ConvexPolygon item, IEnumerable<Vector2> vertexs)
        {
            vertexs.Process(v => item.AddVertex(v));
        }
        static public void AddVertexs(this ConvexPolygon item, params Vector2[] vertexs)
        {
            item.AddVertexs((IEnumerable<Vector2>)vertexs);
        }
    }
}