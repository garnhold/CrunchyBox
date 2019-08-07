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
    public class EditorGUIElementAttachment_Singular_Label_GUIContent_Block : EditorGUIElementAttachment_Singular_Label_GUIContent
    {
        private Rect label_rect;

        private float indent_width;
        private float label_height;

        public EditorGUIElementAttachment_Singular_Label_GUIContent_Block(GUIContent l, float i, float h) : base(l)
        {
            label_rect = new Rect();

            indent_width = i;
            label_height = h;
        }

        public EditorGUIElementAttachment_Singular_Label_GUIContent_Block(GUIContent l, float i) : this(l, i, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElementAttachment_Singular_Label_GUIContent_Block(GUIContent l) : this(l, EditorGUIElement_Single.DEFAULT_HEIGHT) { }

        public override Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state)
        {
            if (HasLabel())
            {
                rect.SplitByYBottomOffset(label_height, out label_rect, out rect);
                rect = rect.GetShrunkLeft(indent_width);
            }

            return rect;
        }

        public override void DrawInternal(Rect view)
        {
            if (HasLabel())
                GUI.Label(label_rect, GetLabel());
        }

        public override float ModifyElementHeight(float height)
        {
            if (HasLabel())
                return height + label_height;

            return height;
        }
    }
}