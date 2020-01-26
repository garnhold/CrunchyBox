using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public abstract class EditorGUIElement_Foldout<T> : EditorGUIElement where T : EditorGUIElement_Container
    {
        private Rect label_rect;

        private string text;
        private T container;
        private float single_height;

        protected abstract void SetIsOpenInternal(bool is_open);
        protected abstract bool GetIsOpenInternal();

        protected override void InitializeInternal()
        {
            container.Initialize();
        }

        protected override float DoPlanInternal()
        {
            float height = single_height;

            if (IsOpen())
                height += container.Plan(GetContentsWidth(), GetLayoutState());

            return height;
        }

        protected override Rect LayoutElementInternal(Rect rect)
        {
            rect.SplitByYBottomOffset(single_height, out label_rect, out rect);

            return rect;
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            container.Layout(position);
        }

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            SetIsOpen(EditorGUI.Foldout(label_rect, IsOpen(), text, true));
        }

        protected override void DrawContentsInternal(int draw_id, Rect view)
        {
            if (IsOpen())
                container.Draw(draw_id, view);
        }

        protected override void UnwindInternal(int draw_id)
        {
            if(IsOpen())
                container.Unwind(draw_id);
        }

        public EditorGUIElement_Foldout(string t, T c, float h)
        {
            text = t;
            single_height = h;

            container = c;
            container.SetParent(this);
            container.AddAttachment(new EditorGUIElementAttachment_Singular_Padding_Indent());
        }

        public EditorGUIElement_Foldout(string t, T c) : this(t, c, EditorGUIElement_Single.DEFAULT_HEIGHT) { }

        public void SetIsOpen(bool is_open)
        {
            if (IsOpen() != is_open)
            {
                SetIsOpenInternal(is_open);
                InvalidatePlan();
            }
        }

        public bool IsOpen()
        {
            return GetIsOpenInternal();
        }

        public bool IsClosed()
        {
            if (IsOpen() == false)
                return true;

            return false;
        }

        public T GetContainer()
        {
            return container;
        }
    }
}