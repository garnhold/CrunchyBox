using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<T> : EditorGUIElement_Single_EditPropertyValue_Simple<T>
    {
        private EditorGUIElementAttachment_Singular_GUIContentLabel label;

        protected abstract T DrawBuiltInFieldInternal(Rect rect, GUIContent label, T value);

        protected override T DrawFieldInternal(Rect rect, T value)
        {
            return DrawBuiltInFieldInternal(rect, GetLabel(), value);
        }

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

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn(EditProperty_Value p, float h) : base(p, h)
        {
            label = new EditorGUIElementAttachment_Singular_GUIContentLabel_Inline();
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }

        public GUIContent GetLabel()
        {
            return label.GetLabel();
        }
    }
}