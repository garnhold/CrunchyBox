using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_ScrollBox<T> : EditorGUIElement where T : EditorGUIElement
    {
        private Rect scroll_box_rect;

        private Vector2 scroll_position;

        private T element;
        private float height;

        static public readonly float SCROLL_BAR_WIDTH = 18.0f;

        protected override void InitializeInternal()
        {
            element.Initialize();
        }

        protected override float DoPlanInternal()
        {
            element.Plan(GetContentsWidth() - SCROLL_BAR_WIDTH, GetLayoutState());

            return height;
        }

        protected override Rect LayoutElementInternal(Rect rect)
        {
            scroll_box_rect = rect;

            return rect;
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            element.Layout(new Vector2(0.0f, 0.0f));
        }

        protected override void DrawContentsInternal(int draw_id, Rect view)
        {
            Rect visible_box_rect = scroll_box_rect.GetIntersection(view);
            Rect visible_space_rect = visible_box_rect.GetShifted(scroll_position - scroll_box_rect.min);

            scroll_position = GUI.BeginScrollView(scroll_box_rect, scroll_position, element.GetElementRect());
                element.Draw(draw_id, visible_space_rect);
            GUI.EndScrollView(IsOverflown());
        }

        protected override void UnwindInternal(int draw_id)
        {
            element.Unwind(draw_id);
        }

        public EditorGUIElement_ScrollBox(T e, float h)
        {
            element = e;
            element.SetParent(this);

            height = h;

            AddAttachment(new EditorGUIElementAttachment_Singular_Margin(0.0f));
        }

        public void SetHeight(float h)
        {
            height = h;

            InvalidatePlan();
        }

        public T GetElement()
        {
            return element;
        }

        public bool IsOverflown()
        {
            if (scroll_box_rect.CouldContain(element.GetElementRect()) == false)
                return true;

            return false;
        }
    }
}