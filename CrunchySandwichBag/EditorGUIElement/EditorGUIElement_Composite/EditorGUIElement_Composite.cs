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

        protected override void InitilizeInternal()
        {
            if (element != null)
                element.Initilize();
        }

        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            if (element != null)
                element.AddAttachment(attachment);

            return false;
        }

        protected override void LayoutContentsInternal(Rect rect, float label_width)
        {
            if (element != null)
                element.Layout(rect, label_width);
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

        public EditorGUIElement_Composite(EditorGUIElement e)
        {
            element = e;
            element.SetParent(this);

            element.AddAttachments(GetAttachments());
        }
    }
}