using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(LayerEX), true)]
    public class EditorGUIElement_EditPropertySingleValue_Popup_LayerEX : EditorGUIElement_EditPropertySingleValue_Popup<LayerEX>
    {
        public EditorGUIElement_EditPropertySingleValue_Popup_LayerEX(EditProperty_Single_Value p) : base(p) { }

        public override IEnumerable<LayerEX> GetOptions()
        {
            return LayerEXExtensions.GetAllLayers();
        }
    }
}