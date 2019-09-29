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

        public virtual EditorGUIElementPlan PlanElementInternal(EditorGUIElementPlan plan, EditorGUILayoutState state) { return plan; }
        public virtual EditorGUIElementPlan PlanContentsInternal(EditorGUIElementPlan plan, EditorGUILayoutState state) { return plan; }

        public virtual float ModifyFootprintHeight(float height, EditorGUILayoutState state) { return height; }

        public virtual void LayoutInternal(Vector2 position, float footprint_height) { }

        public virtual void PreDrawInternal() { }
        public virtual void DrawInternal(Rect view) { }
        public virtual void PostDrawInternal() { }

        public virtual void UnwindInternal() { }
    }
}