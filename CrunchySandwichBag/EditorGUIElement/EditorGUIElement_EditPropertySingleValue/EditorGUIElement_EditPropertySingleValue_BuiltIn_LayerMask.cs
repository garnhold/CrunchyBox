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
    public class EditorGUIElement_EditPropertySingleValue_BuiltIn_LayerMask : EditorGUIElement_EditPropertySingleValue_BuiltIn<LayerMask>
    {
        protected override LayerMask DrawBuiltInInternal(Rect rect, GUIContent label, LayerMask value)
        {
            return EditorGUI.MaskField(
                rect,
                label,
                value.value,
                Ints.Range(0, 31, true).Convert(i => LayerMask.LayerToName(i)).ToArray()
            );
        }

        public EditorGUIElement_EditPropertySingleValue_BuiltIn_LayerMask(EditProperty_Single_Value p) : base(p) { }
    }
}