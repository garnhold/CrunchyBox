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
    public abstract class EditorGUIElement_Complex : EditorGUIElement
    {
        private EditorGUIElement element;

        protected abstract bool NeedRecreation();
        protected abstract EditorGUIElement Recreate();

        protected override void InitilizeInternal()
        {
            if (NeedRecreation())
            {
                element = Recreate();
                if (element != null)
                {
                    element.SetParent(this);
                    element.AddAttachments(GetAttachments());
                }
            }

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

        protected override float CalculateLayoutLabelWidthInternal(float incoming)
        {
            if (element != null)asfd
                return element.CalculateElementHeightInternal(incoming);

            return incoming;
        }

        protected override void DrawContentsInternal(Rect view)
        {
            if (element != null)
            {
                element.Draw(view);
                element.Unwind();
            }

            if (NeedRecreation())
                Initilize();
        }

        protected override float CalculateElementHeightInternal()
        {
            if (element != null)
                return element.GetHeight();

            return 0.0f;
        }

        public EditorGUIElement_Complex()
        {
        }
    }

    public abstract class EditorGUIElement_Complex<T> : EditorGUIElement_Complex
    {
        private T current_state;
        private bool force_recreation;

        protected abstract T PullState();
        protected abstract EditorGUIElement PushState();

        protected override bool NeedRecreation()
        {
            if (force_recreation || current_state.NotEqualsEX(PullState()))
                return true;

            return false;
        }

        protected override EditorGUIElement Recreate()
        {
            current_state = PullState();
            force_recreation = false;

            return PushState();
        }

        public EditorGUIElement_Complex()
        {
            force_recreation = true;
        }

        public void ForceRecreation()
        {
            force_recreation = true;
        }
    }
}