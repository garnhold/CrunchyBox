using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Complex_MissingScriptSerializedObject : EditorGUIElement_Complex<UnityEngine.Object>
    {
        private SerializedObject serialized_object;

        protected override UnityEngine.Object PullState()
        {
            return serialized_object.targetObject;
        }

        protected override EditorGUIElement PushState()
        {
            EditorGUIElement_Container_Auto children;
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            container.AddChild(new EditorGUIElement_SerializedProperty_Field(serialized_object.FindProperty("m_Script")))
                .LabelWithGUIContent("Missing Script");

            children = container.AddChild(new EditorGUIElement_Container_Auto_Simple_VerticalStrip());

            serialized_object.GetImmediateChildren(false)
                .Process(p => children.AddChild(new EditorGUIElement_SerializedProperty_Field(p)).LabelWithGUIContent(p.GetGUIContentLabel()));

            children.AddAttachment(new EditorGUIElementAttachment_Disabled());

            return container;
        }

        public EditorGUIElement_Complex_MissingScriptSerializedObject(SerializedObject s)
        {
            serialized_object = s;
            AddAttachment(new EditorGUIElementAttachment_SerializedObjectSection(s));
        }
    }
}