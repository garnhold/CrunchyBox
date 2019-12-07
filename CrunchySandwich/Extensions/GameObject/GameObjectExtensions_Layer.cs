using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class GameObjectExtensions_Layer
    {
        static public void SetLayer(this GameObject item, LayerEX layer)
		{
            if (item.layer != layer.GetId())
                item.layer = layer.GetId();
		}
    }
}