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
		static public void SetSpacarMeshSize(this GameObject item, Vector3 size)
		{
			item.transform.SetSpacarMeshSize(size);
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

		static public void SetSpacarMeshSize(this Component item, Vector3 size)
		{
			item.transform.SetSpacarMeshSize(size);
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