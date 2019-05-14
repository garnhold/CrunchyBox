using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshFilterExtensions_Size
    {
        static public void SetSize(this MeshFilter item, Vector3 size)
        {
            item.SetSpacarScale(size.GetComponentDivide(item.GetNativeSize()));
        }

        static public Vector3 GetNativeSize(this MeshFilter item)
        {
            Mesh mesh = item.sharedMesh;

            if(mesh != null)
                return mesh.bounds.size;

            return Vector3.zero;
        }

        static public Vector3 GetSize(this MeshFilter item)
        {
            return item.GetNativeSize().GetComponentMultiply(item.GetSpacarScale());
        }

        static public Vector3 GetExtents(this MeshFilter item)
        {
            return item.GetSize() * 0.5f;
        }
    }
}