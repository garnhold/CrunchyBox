using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public abstract class EditorWindowEX_Simple : EditorWindowEX
    {
        protected virtual void InitializeRootEditorGUIElement(EditorGUIElement_Container_Auto root) { }
        protected virtual void InitializeRootEditorSceneElement(EditorSceneElement_Container_Auto root) { }

        protected override EditorGUIElement CreateRootEditorGUIElement()
        {
            EditorGUIElement_Container_Auto_Simple_VerticalStrip root = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            InitializeRootEditorGUIElement(root);
            return root;
        }

        protected override EditorSceneElement CreateRootEditorSceneElement()
        {
            EditorSceneElement_Container_Auto root = new EditorSceneElement_Container_Auto_Simple_Normal();

            InitializeRootEditorSceneElement(root);
            return root;
        }
    }
}