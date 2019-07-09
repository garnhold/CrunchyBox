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
    public class EditorGUIElementAttachment_Singular_Padding : EditorGUIElementAttachment_Singular
    {
        private float left;
        private float right;
        private float top;
        private float bottom;

        public EditorGUIElementAttachment_Singular_Padding(float l, float r, float t, float b) : base("Padding")
        {
            left = l;
            right = r;
            top = t;
            bottom = b;
        }

        public EditorGUIElementAttachment_Singular_Padding(float lr, float tb) : this(lr, lr, tb, tb) { }
        public EditorGUIElementAttachment_Singular_Padding(float p) : this(p, p) { }

        public override Rect LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            return rect.GetShrunk(left, bottom, right, top);
        }
    }
}