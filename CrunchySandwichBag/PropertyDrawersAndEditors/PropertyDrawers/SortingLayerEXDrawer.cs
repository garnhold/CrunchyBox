using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;
using CrunchySandwichBag;

using SortingLayerPopup = CrunchySandwichBag.EditorGUIElement_Popup_SerializedProperty_Represented_Int<CrunchySandwich.SortingLayerEX>;

namespace CrunchySandwichBag
{
    [CustomPropertyDrawer(typeof(SortingLayerEX))]
    public class SortingLayerEXDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            root.AddChild(new SortingLayerPopup(property.FindPropertyRelative("id"), SortingLayerEX.GetAllSortingLayers(), l => l.GetId()));
        }
    }
}