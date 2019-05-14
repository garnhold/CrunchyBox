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
    public class EditorGUIElementAttachment_Singular_GUIContentLabel_Inline : EditorGUIElementAttachment_Singular_GUIContentLabel
    {
        private Rect label_rect;

        public EditorGUIElementAttachment_Singular_GUIContentLabel_Inline(GUIContent l) : base(l)
        {
            label_rect = new Rect();
        }

        public EditorGUIElementAttachment_Singular_GUIContentLabel_Inline() : this(GUIContent.none) { }

        public override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            if (HasLabel())
                rect.SplitByXLeftOffset(label_width, out label_rect, out rect);

            return rect;
        }

        public override void DrawInternal(Rect view)
        {
            if (HasLabel())
                GUI.Label(label_rect, GetLabel());
        }
    }
}