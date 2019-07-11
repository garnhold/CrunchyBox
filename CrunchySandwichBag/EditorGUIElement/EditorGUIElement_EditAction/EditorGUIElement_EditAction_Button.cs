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
    public class EditorGUIElement_EditAction_Button : EditorGUIElement_EditAction
    {
        private bool is_pressed;

        protected override void DrawElementInternal(Rect view)
        {
            is_pressed = GUI.Button(GetElementRect(), GetEditAction().GetName());
        }

        protected override void UnwindInternal()
        {
            if (is_pressed)
                GetEditAction().Execute();
        }

        public EditorGUIElement_EditAction_Button(EditAction a) : base(a) { }
    }
}