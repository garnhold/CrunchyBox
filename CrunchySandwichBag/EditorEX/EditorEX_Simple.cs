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
        protected virtual void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, T item, SerializedObject serialized_object) { }
        protected virtual void InitilizeRootEditorSceneElement(EditorSceneElement_Container_Auto root, T item, SerializedObject serialized_object) { }

        protected override EditorGUIElement CreateRootEditorGUIElement(T item, SerializedObject serialized_object)
        {
            EditorGUIElement_Container_Auto_Simple_VerticalStrip root = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            InitilizeRootEditorGUIElement(root, item, serialized_object);
            return root;
        }

        protected override EditorSceneElement CreateRootEditorSceneElement(T item, SerializedObject serialized_object)
        {
            EditorSceneElement_Container_Auto root = new EditorSceneElement_Container_Auto_Simple_Normal();

            InitilizeRootEditorSceneElement(root, item, serialized_object);
            return root;
        }
    }
}