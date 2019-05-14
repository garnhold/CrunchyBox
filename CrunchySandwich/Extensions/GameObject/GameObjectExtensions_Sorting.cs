using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class GameObjectExtensions_Sorting
    {
        static public SortingLayerEX GetSortingLayer(this GameObject item)
        {
            return item.GetComponentValueUpward<Renderer, SortingLayerEX>(r => r.GetSortingLayer());
        }
    }
}