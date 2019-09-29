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

        protected override void InitializeInternal()
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
                element.Initialize();
        }

        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            if (element != null)
                element.AddAttachment(attachment);

            return false;
        }

        protected override float DoPlanInternal()
        {
            if (element != null)
                return element.Plan(GetContentsWidth(), GetLayoutState());

            return 0.0f;
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            if (element != null)
                element.Layout(position);
        }

        protected override void DrawContentsInternal(Rect view)
        {
            if (element != null)
            {
                element.Draw(view);
                element.Unwind();
            }

            if (NeedRecreation())
                Initialize();
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