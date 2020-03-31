using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class MeshFilterExtensions_Bounds
    {
        //TODO: Make this work for arbitrary origin meshes

        static public void SetBounds(this MeshFilter item, Bounds bounds)
        {
            item.SetSize(bounds.size);
            item.SetSpacarPosition(bounds.center);
        }

        static public Bounds GetBounds(this MeshFilter item)
        {
            return new Bounds(item.GetSpacarPosition(), item.GetSize());
        }
    }
}