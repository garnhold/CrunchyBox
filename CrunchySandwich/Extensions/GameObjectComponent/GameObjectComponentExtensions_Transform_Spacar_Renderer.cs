using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Spacar_Renderer
    {
		static public Bounds GetSpacarRendererBounds(this GameObject item)
		{
			return item.transform.GetSpacarRendererBounds();
		}

		static public Bounds GetSpacarRendererBounds(this Component item)
		{
			return item.transform.GetSpacarRendererBounds();
		}

	}
}