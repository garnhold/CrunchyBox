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
    
    public abstract class PropertyDrawerEX_Simple : PropertyDrawerEX
    {
        protected abstract void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SerializedProperty property);

        public override EditorGUIElement CreateEditorGUIElement(SerializedProperty property)
        {
            EditorGUIElement_Container_Auto root = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            InitilizeRootEditorGUIElement(root, property);
            return root;
        }
    }
}