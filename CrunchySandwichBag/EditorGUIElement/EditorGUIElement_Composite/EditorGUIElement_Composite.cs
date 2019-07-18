using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElement_Composite : EditorGUIElement
    {
        private EditorGUIElement element;

        protected abstract EditorGUIElement CreateElement();

        protected override void InitilizeInternal()
        {
            if (element == null)
            {
                element = CreateElement();
                element.SetParent(this);

                element.AddAttachments(GetAttachments());
            }

            element.Initilize();
        }

        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            if (element != null)
                element.AddAttachment(attachment);

            return false;
        }

        protected override void LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            if (element != null)
                element.Layout(rect, state);
        }

        protected override void DrawContentsInternal(Rect view)
        {
            if (element != null)
            {
                element.Draw(view);
                element.Unwind();
            }
        }

        protected override float CalculateElementHeightInternal()
        {
            if (element != null)
                return element.GetHeight();

            return 0.0f;
        }

        public EditorGUIElement_Composite() { }
    }
}