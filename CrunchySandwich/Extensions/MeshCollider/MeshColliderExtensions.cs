using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
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