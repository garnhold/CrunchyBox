using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using Crunchy.Dough;
using Crunchy.Sandwich;
using Crunchy.SandwichBag;

using SortingLayerPopup = Crunchy.SandwichBag.EditorGUIElement_Popup_SerializedProperty_Represented_Int<Crunchy.Sandwich.SortingLayerEX>;

namespace Crunchy.SandwichBag
{
    [CustomPropertyDrawer(typeof(SortingLayerEX))]
    public class SortingLayerEXDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            root.AddChild(new SortingLayerPopup(property.FindPropertyRelative("id"), SortingLayerEXExtensions.GetAllSortingLayers(), l => l.GetId()));
        }
    }
}