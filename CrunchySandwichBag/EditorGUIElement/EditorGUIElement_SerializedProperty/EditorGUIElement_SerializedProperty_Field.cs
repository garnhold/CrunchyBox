using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_SerializedProperty_Field : EditorGUIElement_SerializedProperty
    {
        private Rect element_rect;
        private EditorGUIElementAttachment_Singular_GUIContentLabel_Inline label;

        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_GUIContentLabel_Inline cast;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_GUIContentLabel_Inline>(out cast))
            {
                label = cast;
                return false;
            }

            return true;
        }

        protected override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            element_rect = rect;

            return rect;
        }

        protected override void DrawElementInternal(Rect view)
        {
            EditorGUI.PropertyField(element_rect, GetSerializedProperty(), label.GetLabel());
        }

        protected override float CalculateElementHeightInternal()
        {
            return EditorGUI.GetPropertyHeight(GetSerializedProperty(), label.GetLabel());
        }

        public EditorGUIElement_SerializedProperty_Field(SerializedProperty s) : base(s)
        {
            label = new EditorGUIElementAttachment_Singular_GUIContentLabel_Inline();
        }
    }
}