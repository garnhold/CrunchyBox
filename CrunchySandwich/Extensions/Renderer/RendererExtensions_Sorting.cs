using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RendererExtensions_Sorting
    {
        static public void SetSortingLayer(this Renderer item, SortingLayerEX layer)
        {
            item.sortingLayerID = layer.IfNotNull(l => l.GetId());
        }
        static public void SetSortingOrder(this Renderer item, int order)
        {
            item.sortingOrder = order;
        }
        static public void SetSortingLayerAndOrder(this Renderer item, SortingLayerEX layer, int order)
        {
            item.SetSortingLayer(layer);
            item.SetSortingOrder(order);
        }

        static public int GetSortingOrder(this Renderer item)
        {
            return item.sortingOrder;
        }

        static public SortingLayerEX GetSortingLayer(this Renderer item)
        {
            return new SortingLayerEX(item.sortingLayerID);
        }

        static public int ApproximateGlobalSortingOrder(this Renderer item, int layer_size)
        {
            return item.GetSortingLayer().GetOrder() * layer_size + item.GetSortingOrder();
        }
        static public int ApproximateGlobalSortingOrder(this Renderer item)
        {
            return item.ApproximateGlobalSortingOrder(1024);
        }
    }
}