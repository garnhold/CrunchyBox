using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class MeshBuilderExtensions_ConvexPolygons
    {
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