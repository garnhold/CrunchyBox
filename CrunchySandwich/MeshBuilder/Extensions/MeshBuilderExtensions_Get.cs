using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class MeshBuilderExtensions_Get
    {
        static public IEnumerable<Triangle3> GetTriangles(this MeshBuilder item)
        {
            return item.GetVertexs().MakeIndexedTriangles(item.GetIndexs());
        }
    }
}