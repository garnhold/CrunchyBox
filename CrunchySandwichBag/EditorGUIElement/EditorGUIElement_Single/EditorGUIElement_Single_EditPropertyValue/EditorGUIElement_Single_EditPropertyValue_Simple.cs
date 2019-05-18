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
    public abstract class EditorGUIElement_Single_EditPropertyValue_Simple<T> : EditorGUIElement_Single_EditPropertyValue
    {
        private EditorGUIElementAttachment_Singular_GUIContentLabel label;

        protected abstract T DrawFieldInternal(Rect rect, GUIContent label, T value);

        protected override bool DrawSingleInternal(Rect rect)
        {
            T old_value;

            if(GetEditPropertyValue().TryGetContents<T>(out old_value))
            {
                T new_value = DrawFieldInternal(rect, GetLabel(), old_value);

                if(new_value.NotEqualsEX(old_value))
                    GetEditPropertyValue().SetContents(new_value);

                return true;
            }

            return false;
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

        public EditorGUIElement_Single_EditPropertyValue_Simple(EditProperty_Value p, float h) : base(p, h)
        {
            label = new EditorGUIElementAttachment_Singular_GUIContentLabel_Inline();
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }

        public GUIContent GetLabel()
        {
            return label.GetLabel();
        }
    }
}