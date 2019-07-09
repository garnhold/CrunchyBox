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
    public abstract class EditorGUIElement_Foldout<T> : EditorGUIElement where T : EditorGUIElement_Container
    {
        private Rect label_rect;

        private string text;
        private T container;
        private float single_height;

        protected abstract void SetIsOpenInternal(bool is_open);
        protected abstract bool GetIsOpenInternal();

        protected override void InitilizeInternal()
        {
            container.Initilize();
        }

        protected override Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state)
        {
            rect.SplitByYBottomOffset(single_height, out label_rect, out rect);

            return rect;
        }

        protected override void LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            container.Layout(rect, state);
        }

        protected override void DrawElementInternal(Rect view)
        {
            SetIsOpen(EditorGUI.Foldout(label_rect, IsOpen(), text, true));
        }

        protected override void DrawContentsInternal(Rect view)
        {
            if (IsOpen())
                container.Draw(view);
        }

        protected override void UnwindInternal()
        {
            if(IsOpen())
                container.Unwind();
        }

        protected override float CalculateElementHeightInternal()
        {
            float height = single_height;

            if (IsOpen())
                height += container.GetHeight();

            return height;
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
                InvalidateHeight();
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