using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;
using CrunchySandwichBag;

namespace CrunchySandwichBag
{
    [CustomPropertyDrawer(typeof(SceneEX))]
    public class SceneEXDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            root.AddChild(new EditorGUIElement_Single_SerializedProperty_TypedObjectField(property.FindPropertyRelative("scene_asset"), typeof(SceneAsset)));
        }
    }
}