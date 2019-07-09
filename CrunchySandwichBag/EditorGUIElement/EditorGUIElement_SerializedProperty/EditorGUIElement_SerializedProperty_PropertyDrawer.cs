﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_SerializedProperty_PropertyDrawer : EditorGUIElement_SerializedProperty
    {
        private Rect element_rect;
        private EditorGUIElementAttachment_Singular_GUIContentLabel label;

        private PropertyDrawer property_drawer;

        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_GUIContentLabel cast;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_GUIContentLabel>(out cast))
            {
                label = cast;
                return false;
            }

            return true;
        }

        protected override Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state)
        {
            element_rect = rect;

            return rect;
        }

        protected override void DrawElementInternal(Rect view)
        {
            property_drawer.OnGUI(element_rect, GetSerializedProperty(), label.GetLabel());

            InvalidateHeight();
        }

        protected override float CalculateElementHeightInternal()
        {
            return property_drawer.GetPropertyHeight(GetSerializedProperty(), label.GetLabel());
        }

        public EditorGUIElement_SerializedProperty_PropertyDrawer(SerializedProperty s, PropertyDrawer p) : base(s)
        {
            property_drawer = p;

            label = new EditorGUIElementAttachment_Singular_GUIContentLabel_Inline();
        }
    }
}