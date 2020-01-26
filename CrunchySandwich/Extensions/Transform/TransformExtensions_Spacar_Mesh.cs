using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TransformExtensions_Spacar_Mesh
    {
        static public void SetSpacarMeshAsLine(this Transform item, Axis axis, Vector3 point1, Vector3 point2, float total_margin = 0.0f)
        {
            Vector3 diff = point2 - point1;

            item.SetSpacarPosition(point1.GetMidpoint(point2));
            item.SetSpacarAxis(axis, diff);
            item.SetSpacarMeshDimension(axis, (diff.GetMagnitude() - total_margin).BindAbove(0.0f));
        }

        static public void SetSpacarMeshSize(this Transform item, Vector3 size)
        {
            item.GetComponent<MeshFilter>().SetSize(size);
        }
        static public void SetSpacarMeshWidth(this Transform item, float width)
        {
            item.GetComponent<MeshFilter>().SetWidth(width);
        }
        static public void SetSpacarMeshHeight(this Transform item, float height)
        {
            item.GetComponent<MeshFilter>().SetHeight(height);
        }
        static public void SetSpacarMeshDepth(this Transform item, float depth)
        {
            item.GetComponent<MeshFilter>().SetDepth(depth);
        }
        static public void SetSpacarMeshDimension(this Transform item, Axis axis, float length)
        {
            item.GetComponent<MeshFilter>().SetDimension(axis, length);
        }

        static public void SetSpacarMeshBounds(this Transform item, Bounds bounds)
        {
            item.GetComponent<MeshFilter>().SetBounds(bounds);
        }

        static public Vector3 GetSpacarMeshSize(this Transform item)
        {
            return item.GetComponent<MeshFilter>().GetSize();
        }

        static public Bounds GetSpacarMeshBounds(this Transform item)
        {
            return item.GetComponent<MeshFilter>().GetBounds();
        }
    }
}