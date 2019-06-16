using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshExtensions_Triangle
    {
        static public IEnumerable<Triangle3> GetTriangles(this Mesh item)
        {
            return item.vertices.MakeIndexedTriangles(item.triangles);
        }
    }
}