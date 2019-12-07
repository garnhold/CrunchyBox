using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Complex_SerializedObject : EditorGUIElement_Complex<UnityEngine.Object>
    {
        private SerializedObject serialized_object;

        protected override UnityEngine.Object PullState()
        {
            return serialized_object.targetObject;
        }

        protected override EditorGUIElement PushState()
        {
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (serialized_object.targetObject == null)
                container.AddChild(new EditorGUIElement_SerializedProperty_Field(serialized_object.FindProperty("m_Script")).LabelWithGUIContent("Problem Script"));

            container.AddChildren(
                serialized_object.GetImmediateChildren(true)
                    .Skip(p => p.name == "m_Script")
                    .Convert<SerializedProperty, EditorGUIElement>(p => new EditorGUIElement_Complex_SerializedProperty_FieldEX(p).LabelWithGUIContent(p.GetGUIContentLabel()))
            );

            return container;
        }

        public EditorGUIElement_Complex_SerializedObject(SerializedObject s)
        {
            serialized_object = s;
        }
    }
}