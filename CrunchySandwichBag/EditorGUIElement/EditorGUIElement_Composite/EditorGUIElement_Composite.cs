using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_Composite : EditorGUIElement
    {
        private EditorGUIElement element;

        protected abstract EditorGUIElement CreateElement();

        protected override void InitializeInternal()
        {
            if (element == null)
            {
                element = CreateElement();
                element.SetParent(this);

                element.AddAttachments(GetAttachments());
            }

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
            element.IfNotNull(e => e.Layout(position));
        }

        protected override void DrawContentsInternal(int draw_id, Rect view)
        {
            element.IfNotNull(e => e.Draw(draw_id, view));
        }

        protected override void UnwindInternal(int draw_id)
        {
            element.IfNotNull(e => e.Unwind(draw_id));
        }

        public EditorGUIElement_Composite() { }
    }
}