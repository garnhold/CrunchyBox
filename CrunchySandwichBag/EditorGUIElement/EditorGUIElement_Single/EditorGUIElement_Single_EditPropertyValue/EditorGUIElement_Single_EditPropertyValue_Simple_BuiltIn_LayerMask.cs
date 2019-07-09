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
    [EditorGUIElementForType(typeof(LayerMask), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_LayerMask : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<LayerMask>
    {
        protected override LayerMask DrawBuiltInFieldInternal(Rect rect, GUIContent label, LayerMask value)
        {
            return EditorGUI.MaskField(
                rect,
                label,
                value.value,
                Ints.Range(0, 31, true).Convert(i => LayerMask.LayerToName(i)).ToArray()
            );
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_LayerMask(EditProperty_Value s, float h) : base(s, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_LayerMask(EditProperty_Value s) : this(s, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}