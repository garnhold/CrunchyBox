using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<T> : EditorGUIElement_EditPropertySingleValue_Basic<T>
    {
        private EditorGUIElementAttachment_Singular_Label_GUIContent label;

        protected abstract T DrawBuiltInInternal(Rect rect, GUIContent label, T value);

        protected override T DrawValueInternal(Rect rect, T value)
        {
 	        return DrawBuiltInInternal(rect, GetLabel(), value);
        }

        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_Label_GUIContent cast;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_Label_GUIContent>(out cast))
            {
                label = cast;
                return false;
            }

            return true;
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn(EditProperty_Single_Value p) : base(p)
        {
            label = new EditorGUIElementAttachment_Singular_Label_GUIContent_Inline();
        }

        public GUIContent GetLabel()
        {
            return label.GetLabel();
        }
    }
}