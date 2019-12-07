using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    using SandwichBag;
    
    [CustomPropertyDrawer(typeof(CustomAsset), true)]
    public class CustomAssetDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            root.AddChild(new EditorGUIElement_Complex_SerializedProperty_CustomAsset(property));
        }
    }
}