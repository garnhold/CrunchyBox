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
    public class EditorGUIElementAttachment_Singular_Margin : EditorGUIElementAttachment_Singular
    {
        private float left;
        private float right;
        private float top;
        private float bottom;

        public EditorGUIElementAttachment_Singular_Margin(float l, float r, float t, float b) : base("Margin")
        {
            left = l;
            right = r;
            top = t;
            bottom = b;
        }

        public EditorGUIElementAttachment_Singular_Margin(float lr, float tb) : this(lr, lr, tb, tb) { }
        public EditorGUIElementAttachment_Singular_Margin(float p) : this(p, p) { }

        public override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            return rect.GetShrunk(left, bottom, right, top);
        }

        public override float ModifyElementHeight(float height)
        {
            return height + bottom + top;
        }
    }
}