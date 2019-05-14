using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshColliderExtensions
    {
        static public void SetConvexHull(this MeshCollider item, Mesh mesh)
        {
            item.sharedMesh = mesh;
            item.convex = true;
        }
    }
}