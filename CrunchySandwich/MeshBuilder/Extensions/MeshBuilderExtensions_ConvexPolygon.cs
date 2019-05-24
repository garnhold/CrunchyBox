using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class MeshBuilderExtensions_ConvexPolygon
    {
        static public void AddConvexPolygon(this MeshBuilder item, IList<Vector3> vertex_loop)
        {
            if (vertex_loop.Count >= 3)
            {
                if (vertex_loop.Count == 3)
                    item.AddTriangle(vertex_loop[0], vertex_loop[1], vertex_loop[2]);
                else if (vertex_loop.Count == 4)
                    item.AddQuad(vertex_loop[0], vertex_loop[1], vertex_loop[2], vertex_loop[3]);
                else
                    item.AddTriangleFan(vertex_loop);
            }
        }
        static public void AddConvexPolygon(this MeshBuilder item, IEnumerable<Vector3> v)
        {
            item.AddConvexPolygon(v.ToList());
        }

        static public void AddConvexPolygons(this MeshBuilder item, IEnumerable<IEnumerable<Vector3>> to_add)
        {
            to_add.Process(i => item.AddConvexPolygon(i));
        }
        static public void AddConvexPolygons(this MeshBuilder item, params IEnumerable<Vector3>[] to_add)
        {
            item.AddConvexPolygons((IEnumerable<IEnumerable<Vector3>>)to_add);
        }
    }
}