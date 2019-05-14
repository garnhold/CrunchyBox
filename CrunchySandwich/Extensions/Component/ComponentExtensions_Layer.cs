using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class ComponentExtensions_Layer
    {
        static public void SetLayer(this Component item, LayerEX layer)
		{
            item.gameObject.SetLayer(layer);
		}
    }
}