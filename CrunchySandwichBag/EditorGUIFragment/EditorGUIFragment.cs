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
    public abstract class EditorGUIFragment
    {
        private Rect element_rect;
        private GUIControl control;

        protected abstract bool HandleEvent(Rect rect, EventType type, Event vnt);

        protected void CaptureControl()
        {
            control.CaptureControl();
        }

        protected void ReleaseControl()
        {
            control.ReleaseControl();
        }

        public EditorGUIFragment()
        {
            control = new GUIControl(FocusType.Passive);
        }

        public void Layout(Rect rect)
        {
            element_rect = rect;
        }

        public void Draw()
        {
            control.Update((t, e) => HandleEvent(element_rect, t, e));
        }

        public bool IsControlCaptured()
        {
            return control.IsControlCaptured();
        }
    }
}