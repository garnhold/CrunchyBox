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
    public class EditorGUIElement_Complex_SerializedProperty_Generic : EditorGUIElement_Complex_SerializedProperty<Type>
    {
        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_Label_GUIContent_Inline label;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_Label_GUIContent_Inline>(out label))
                attachment = new EditorGUIElementAttachment_Singular_Label_GUIContent_Block(label.GetLabel());

            return base.HandleAttachment(ref attachment);
        }

        protected override Type PullState()
        {
            return GetSerializedProperty().GetVariableType();
        }

        protected override EditorGUIElement PushState()
        {
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            container.AddChildren(
                GetSerializedProperty().GetImmediateChildren(true)
                    .Convert<SerializedProperty, EditorGUIElement>(p => new EditorGUIElement_Complex_SerializedProperty_FieldEX(p).LabelWithGUIContent(p.GetGUIContentLabel()))
            );

            return container;
        }

        public EditorGUIElement_Complex_SerializedProperty_Generic(SerializedProperty s) : base(s)
        {
        }
    }
}