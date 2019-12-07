using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using Crunchy.Dough;
using Crunchy.Sandwich;
using Crunchy.SandwichBag;

using LayerPopup = Crunchy.SandwichBag.EditorGUIElement_Popup_SerializedProperty_Represented_Int<Crunchy.Sandwich.LayerEX>;

namespace Crunchy.SandwichBag
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