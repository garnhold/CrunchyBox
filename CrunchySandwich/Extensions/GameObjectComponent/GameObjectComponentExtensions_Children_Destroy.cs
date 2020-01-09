using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Children_Destroy
    {
		static public void DestroyChildren(this GameObject item)
        {
			item.GetChildren().Destroy();
        }

        static public void DestroyChildrenImmediate(this GameObject item, bool is_asset = false)
        {
			item.GetChildren().DestroyImmediate(is_asset);
        }

        static public void DestroyChildrenAdvisory(this GameObject item, bool is_asset = false)
        {
			item.GetChildren().DestroyAdvisory(is_asset);
        }

		static public void DestroyChildren(this Component item)
        {
			item.GetChildren().Destroy();
        }

        static public void DestroyChildrenImmediate(this Component item, bool is_asset = false)
        {
			item.GetChildren().DestroyImmediate(is_asset);
        }

        static public void DestroyChildrenAdvisory(this Component item, bool is_asset = false)
        {
			item.GetChildren().DestroyAdvisory(is_asset);
        }

	}
}