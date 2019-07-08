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
    public class EditorGUIElement_Single_HorizontalRule : EditorGUIElement_Single
    {
        protected override bool DrawSingleInternal(Rect rect)
        {
            GUIExtensions.DrawHorizontalRule(rect);

            return true;
        }

        public EditorGUIElement_Single_HorizontalRule(float h) : base(h) { }

        public EditorGUIElement_Single_HorizontalRule() : this(EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}