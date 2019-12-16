using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public abstract class EditorEX_Simple<T> : EditorEX<T> where T : UnityEngine.Object
    {
        protected virtual void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, EditTarget target) { }
        protected virtual void InitilizeRootEditorSceneElement(EditorSceneElement_Container_Auto root, EditTarget target) { }

        protected override EditorGUIElement CreateRootEditorGUIElement(EditTarget target)
        {
            EditorGUIElement_Container_Auto_Simple_VerticalStrip root = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            InitilizeRootEditorGUIElement(root, target);
            return root;
        }

        protected override EditorSceneElement CreateRootEditorSceneElement(EditTarget target)
        {
            EditorSceneElement_Container_Auto root = new EditorSceneElement_Container_Auto_Simple_Normal();

            InitilizeRootEditorSceneElement(root, target);
            return root;
        }
    }
}