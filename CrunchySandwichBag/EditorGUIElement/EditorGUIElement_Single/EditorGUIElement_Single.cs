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
    public abstract class EditorGUIElement_Single : EditorGUIElement
    {
        private Rect element_rect;

        private float single_height;

        static public readonly float DEFAULT_HEIGHT = 16.0f;

        protected abstract bool DrawSingleInternal(Rect rect);

        protected override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            element_rect = rect;

            return rect;
        }

        protected override void DrawElementInternal(Rect view)
        {
            if (DrawSingleInternal(element_rect) == false)
                EditorGUI.LabelField(element_rect, "--Disabled--");
        }

        protected override float CalculateElementHeightInternal()
        {
            return single_height;
        }

        public EditorGUIElement_Single(float h)
        {
            single_height = h;
        }

        public EditorGUIElement_Single() : this(DEFAULT_HEIGHT) { }

        public float GetSingleHeight()
        {
            return single_height;
        }
    }
}