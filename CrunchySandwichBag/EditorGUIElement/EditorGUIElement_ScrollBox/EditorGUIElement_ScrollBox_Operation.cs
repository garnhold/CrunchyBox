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
    public class EditorGUIElement_ScrollBox_Operation<T> : EditorGUIElement_ScrollBox<T> where T : EditorGUIElement
    {
        private float max_height;
        private Operation<Rect, T, float, float> operation;

        protected override Rect CalculateScrollBoxContentsRect(float width, float label_width)
        {
            return operation(GetElement(), width, label_width);
        }

        protected override float CalculateElementHeightInternal()
        {
            return GetElement().GetHeight().Min(max_height);
        }

        public EditorGUIElement_ScrollBox_Operation(Operation<Rect, T, float, float> o, T e, float m) : base(e)
        {
            max_height = m;

            operation = o;
        }

        public EditorGUIElement_ScrollBox_Operation(Operation<Rect, float, float> o, T e, float m) : this((el, w, l) => o(w, l), e, m) { }
        public EditorGUIElement_ScrollBox_Operation(Operation<Rect> o, T e, float m) : this((w, l) => o(), e, m) { }
    }
}