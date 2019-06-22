using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;
using CrunchySandwichBag;

using LayerPopup = CrunchySandwichBag.EditorGUIElement_Popup_SerializedProperty_Represented_Int<CrunchySandwich.LayerEX>;

namespace CrunchySandwichBag
{
    [CustomPropertyDrawer(typeof(LayerEX))]
    public class LayerEXDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            root.AddChild(new LayerPopup(property.FindPropertyRelative("id"), LayerEXExtensions.GetAllLayers(), l => l.GetId()));
        }
    }
}