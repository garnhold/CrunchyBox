using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class ConvexPolygonExtensions_Primitives
    {
        static public IEnumerable<Vector2> GetVertexs(this ConvexPolygon item)
        {
            return item.GetFaces().Convert(f => f.v0);
        }

        static public IEnumerable<Tuple<Vector2, Vector2>> GetEdges(this ConvexPolygon item)
        {
            return item.GetVertexs().CloseLoop().ConvertConnections();
        }

        static public IEnumerable<Vector2> GetNormals(this ConvexPolygon item)
        {
            return item.GetFaces().Convert(f => f.normal);
        }
    }
}