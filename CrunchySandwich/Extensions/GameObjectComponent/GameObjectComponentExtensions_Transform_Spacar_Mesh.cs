using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Spacar_Mesh
    {
        static public void SetSpacarMeshAsLine(this GameObject item, Axis axis, Vector3 point1, Vector3 point2)
        {
            item.transform.SetSpacarMeshAsLine(axis, point1, point2);
        }
        
		static public void SetSpacarMeshSize(this GameObject item, Vector3 size)
		{
			item.transform.SetSpacarMeshSize(size);
		}
        static public void SetSpacarMeshWidth(this GameObject item, float width)
        {
            item.transform.SetSpacarMeshWidth(width);
        }
        static public void SetSpacarMeshHeight(this GameObject item, float height)
        {
            item.transform.SetSpacarMeshHeight(height);
        }
        static public void SetSpacarMeshDepth(this GameObject item, float depth)
        {
            item.transform.SetSpacarMeshDepth(depth);
        }
        static public void SetSpacarMeshDimension(this GameObject item, Axis axis, float length)
        {
            item.transform.SetSpacarMeshDimension(axis, length);
        }

		static public void SetSpacarMeshBounds(this GameObject item, Bounds bounds)
		{
			item.transform.SetSpacarMeshBounds(bounds);
		}

		static public Vector3 GetSpacarMeshSize(this GameObject item)
		{
			return item.transform.GetSpacarMeshSize();
		}

		static public Bounds GetSpacarMeshBounds(this GameObject item)
		{
			return item.transform.GetSpacarMeshBounds();
		}

        static public void SetSpacarMeshAsLine(this Component item, Axis axis, Vector3 point1, Vector3 point2)
        {
            item.transform.SetSpacarMeshAsLine(axis, point1, point2);
        }
        
		static public void SetSpacarMeshSize(this Component item, Vector3 size)
		{
			item.transform.SetSpacarMeshSize(size);
		}
        static public void SetSpacarMeshWidth(this Component item, float width)
        {
            item.transform.SetSpacarMeshWidth(width);
        }
        static public void SetSpacarMeshHeight(this Component item, float height)
        {
            item.transform.SetSpacarMeshHeight(height);
        }
        static public void SetSpacarMeshDepth(this Component item, float depth)
        {
            item.transform.SetSpacarMeshDepth(depth);
        }
        static public void SetSpacarMeshDimension(this Component item, Axis axis, float length)
        {
            item.transform.SetSpacarMeshDimension(axis, length);
        }

		static public void SetSpacarMeshBounds(this Component item, Bounds bounds)
		{
			item.transform.SetSpacarMeshBounds(bounds);
		}

		static public Vector3 GetSpacarMeshSize(this Component item)
		{
			return item.transform.GetSpacarMeshSize();
		}

		static public Bounds GetSpacarMeshBounds(this Component item)
		{
			return item.transform.GetSpacarMeshBounds();
		}

	}
}