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
    public class EditorGUIElement_ScrollBox_Overflow<T> : EditorGUIElement_ScrollBox<T> where T : EditorGUIElement
    {
        private float max_height;

        protected override Rect CalculateScrollBoxContentsRect(float width, float label_width)
        {
            return new Rect(0.0f, 0.0f, width, GetElement().GetHeight());
        }

        protected override float CalculateElementHeightInternal()
        {
            return GetElement().GetHeight().Min(max_height);
        }

        public EditorGUIElement_ScrollBox_Overflow(T e, float m) : base(e)
        {
            max_height = m;
        }
    }
}