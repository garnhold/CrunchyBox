using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Transform_Planar_Renderer
    {
		static public Rect GetPlanarRendererBounds(this GameObject item)
		{
			return item.transform.GetPlanarRendererBounds();
		}

		static public Rect GetPlanarRendererBounds(this Component item)
		{
			return item.transform.GetPlanarRendererBounds();
		}

	}
}