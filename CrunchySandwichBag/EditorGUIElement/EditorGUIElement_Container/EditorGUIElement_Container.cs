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
    public abstract class EditorGUIElement_Container : EditorGUIElement
    {
        public abstract void ClearChildren();
        public abstract bool RemoveChild(EditorGUIElement child);

        public abstract IEnumerable<EditorGUIElement> GetChildren();

        protected override void InitializeInternal()
        {
            GetChildren().Process(c => c.Initialize());
        }

        protected override void DrawContentsInternal(Rect view)
        {
            GetChildren().Process(c => c.Draw(view));
        }

        protected override void UnwindInternal()
        {
            GetChildren().Process(c => c.Unwind());
        }

        public EditorGUIElement_Container()
        {
            AddAttachment(new EditorGUIElementAttachment_Singular_Margin(0.0f));
        }
    }
}