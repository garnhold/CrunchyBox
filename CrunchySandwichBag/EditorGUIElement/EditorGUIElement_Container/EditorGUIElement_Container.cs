using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public abstract class EditorGUIElement_Container : EditorGUIElement
    {
        public abstract void ClearChildren();
        public abstract bool RemoveChild(EditorGUIElement child);

        public abstract IEnumerable<EditorGUIElement> GetChildren();

        protected override void InitializeInternal()
        {
            GetChildren().Process(c => c.Initialize());
        }

        protected override void DrawContentsInternal(int draw_id, Rect view)
        {
            GetChildren().Process(c => c.Draw(draw_id, view));
        }

        protected override void UnwindInternal(int draw_id)
        {
            GetChildren().Process(c => c.Unwind(draw_id));
        }

        public EditorGUIElement_Container()
        {
            AddAttachment(new EditorGUIElementAttachment_Singular_Margin(0.0f));
        }
    }
}