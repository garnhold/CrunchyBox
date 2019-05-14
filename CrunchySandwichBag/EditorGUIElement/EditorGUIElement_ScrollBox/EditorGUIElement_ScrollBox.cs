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
    public abstract class EditorGUIElement_ScrollBox<T> : EditorGUIElement where T : EditorGUIElement
    {
        private Rect scroll_box_rect;

        private Vector2 scroll_position;

        private T element;

        static public readonly float SCROLL_BAR_WIDTH = 18.0f;

        protected abstract Rect CalculateScrollBoxContentsRect(float width, float label_width);

        protected override void InitilizeInternal()
        {
            element.Initilize();
        }

        protected override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            scroll_box_rect = rect;

            return rect;
        }

        protected override void LayoutContentsInternal(Rect rect, float label_width)
        {
            element.Layout(CalculateScrollBoxContentsRect(rect.width - SCROLL_BAR_WIDTH, label_width), label_width);
        }

        protected override void DrawContentsInternal(Rect view)
        {
            Rect visible_box_rect = scroll_box_rect.GetIntersection(view);
            Rect visible_space_rect = visible_box_rect.GetShifted(scroll_position - scroll_box_rect.min);

            scroll_position = GUI.BeginScrollView(scroll_box_rect, scroll_position, element.GetLayoutRect());
                element.Draw(visible_space_rect);
            GUI.EndScrollView(IsOverflown());
        }

        public EditorGUIElement_ScrollBox(T e)
        {
            element = e;
            element.SetParent(this);

            AddAttachment(new EditorGUIElementAttachment_Singular_Margin(0.0f));
        }

        public T GetElement()
        {
            return element;
        }

        public bool IsOverflown()
        {
            if (scroll_box_rect.CouldContain(element.GetLayoutRect()) == false)
                return true;

            return false;
        }
    }
}