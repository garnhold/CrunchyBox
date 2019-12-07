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
    
    [CustomPropertyDrawer(typeof(SceneEX))]
    public class SceneEXDrawer : PropertyDrawerEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property)
        {
            root.AddChild(new EditorGUIElement_Single_SerializedProperty_TypedObjectField(property.FindPropertyRelative("scene_asset"), typeof(SceneAsset)));
        }
    }
}