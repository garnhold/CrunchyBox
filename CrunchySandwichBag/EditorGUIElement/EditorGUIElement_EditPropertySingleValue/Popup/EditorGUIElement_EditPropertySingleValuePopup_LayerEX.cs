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
    [EditorGUIElementForType(typeof(LayerEX), true)]
    public class EditorGUIElement_EditPropertySingleValuePopup_LayerEX : EditorGUIElement_EditPropertySingleValuePopup<LayerEX>
    {
        public EditorGUIElement_EditPropertySingleValuePopup_LayerEX(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<LayerEX> GetOptions()
        {
            return LayerEXExtensions.GetAllLayers();
        }
    }
}