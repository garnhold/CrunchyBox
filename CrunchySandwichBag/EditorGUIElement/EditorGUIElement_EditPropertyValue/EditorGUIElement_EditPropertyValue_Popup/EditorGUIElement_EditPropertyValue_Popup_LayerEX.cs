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
    public class EditorGUIElement_EditPropertyValue_Popup_LayerEX : EditorGUIElement_EditPropertyValue_Popup<LayerEX>
    {
        public EditorGUIElement_EditPropertyValue_Popup_LayerEX(EditProperty_Value p) : base(p) { }

        public override IEnumerable<LayerEX> GetOptions()
        {
            return LayerEXExtensions.GetAllLayers();
        }
    }
}