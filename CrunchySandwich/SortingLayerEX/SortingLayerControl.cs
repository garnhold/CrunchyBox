using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AddComponentMenu("Rendering/Sorting Layer Control")]
    public class SortingLayerControl : InitBehaviour
    {
        [SerializeField]private SortingLayerEX sorting_layer;
        [SerializeField]private int sorting_order;

        protected override void InitilizeInternal()
        {
            GetComponents<Renderer>().Process(r => r.SetSortingLayerAndOrder(sorting_layer, sorting_order));
        }
    }
}