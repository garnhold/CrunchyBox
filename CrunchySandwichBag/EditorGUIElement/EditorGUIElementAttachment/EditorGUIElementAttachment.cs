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
    public abstract class EditorGUIElementAttachment
    {
        public virtual bool PrepareElementForAttachment(EditorGUIElement element) { return true; }

        public virtual Rect LayoutElementInternal(Rect rect, float label_width) { return rect; }
        public virtual Rect LayoutContentsInternal(Rect rect, float label_width) { return rect; }

        public virtual float ModifyElementHeight(float height) { return height; }

        public virtual void PreLayoutInternal(Rect rect, float label_width) { }
        public virtual void PostLayoutInternal(Rect rect, float label_width) { }

        public virtual void PreDrawInternal() { }
        public virtual void DrawInternal(Rect view) { }
        public virtual void PostDrawInternal() { }

        public virtual void UnwindInternal() { }
    }
}