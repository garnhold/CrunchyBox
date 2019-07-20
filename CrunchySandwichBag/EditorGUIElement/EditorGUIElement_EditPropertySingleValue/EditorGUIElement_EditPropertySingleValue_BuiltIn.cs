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
    public abstract class EditorGUIElement_EditPropertySingleValue_BuiltIn<T> : EditorGUIElement_EditPropertySingleValue<T>
    {
        private EditorGUIElementAttachment_Singular_GUIContentLabel label;

        protected abstract T DrawBuiltInInternal(Rect rect, GUIContent label, T value);

        protected override T DrawValueInternal(Rect rect, T value)
        {
 	        return DrawBuiltInInternal(rect, GetLabel(), value);
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

        public EditorGUIElement_EditPropertySingleValue_BuiltIn(EditProperty_Single_Value p) : base(p)
        {
            label = new EditorGUIElementAttachment_Singular_GUIContentLabel_Inline();
        }

        public GUIContent GetLabel()
        {
            return label.GetLabel();
        }
    }
}