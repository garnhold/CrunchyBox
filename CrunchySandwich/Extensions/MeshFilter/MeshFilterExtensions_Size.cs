using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class MeshFilterExtensions_Size
    {
        static public void SetSize(this MeshFilter item, Vector3 size)
        {
            item.SetSpacarScale(size.GetComponentDivide(item.GetNativeSize()));
        }
        static public void SetWidth(this MeshFilter item, float width)
        {
            item.SetSize(item.GetSize().GetWithX(width));
        }
        static public void SetHeight(this MeshFilter item, float height)
        {
            item.SetSize(item.GetSize().GetWithY(height));
        }
        static public void SetDepth(this MeshFilter item, float depth)
        {
            item.SetSize(item.GetSize().GetWithZ(depth));
        }
        static public void SetDimension(this MeshFilter item, Axis axis, float length)
        {
            item.SetSize(item.GetSize().GetWith(axis, length));
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