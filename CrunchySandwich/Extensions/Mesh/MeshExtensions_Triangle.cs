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
            return item.triangles.ChunkStrict(3).Convert(i => Triangle3Extensions.CreatePoints(
                item.vertices.AtIndexs(i)
            ));
        }
    }
}