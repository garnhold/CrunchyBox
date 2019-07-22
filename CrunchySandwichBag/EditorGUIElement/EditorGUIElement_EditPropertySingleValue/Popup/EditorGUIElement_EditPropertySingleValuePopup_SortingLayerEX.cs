using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(SortingLayerEX), true)]
    public class EditorGUIElement_EditPropertySingleValuePopup_SortingLayerEX : EditorGUIElement_EditPropertySingleValuePopup<SortingLayerEX>
    {
        public EditorGUIElement_EditPropertySingleValuePopup_SortingLayerEX(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<SortingLayerEX> GetOptions()
        {
            return SortingLayerEXExtensions.GetAllSortingLayers();
        }
    }
}