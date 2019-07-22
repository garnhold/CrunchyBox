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
    public class EditorGUIElementAttachment_Indent : EditorGUIElementAttachment
    {
        private float amount;

        static public readonly float DEFAULT_INDENT = 18.0f;

        public EditorGUIElementAttachment_Indent(float a)
        {
            amount = a;
        }

        public EditorGUIElementAttachment_Indent() : this(DEFAULT_INDENT) { }

        public override Rect LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            return rect.GetShrunkLeft(amount);
        }
    }
}