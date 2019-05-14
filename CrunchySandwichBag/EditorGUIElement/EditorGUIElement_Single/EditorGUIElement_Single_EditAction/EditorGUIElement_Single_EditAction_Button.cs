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
    public class EditorGUIElement_Single_EditAction_Button : EditorGUIElement_Single_EditAction
    {
        private bool is_pressed;

        protected override bool DrawSingleInternal(Rect rect)
        {
            is_pressed = GUI.Button(rect, GetEditAction().GetName());

            return true;
        }

        protected override void UnwindInternal()
        {
            if (is_pressed)
                GetEditAction().Execute();
        }

        public EditorGUIElement_Single_EditAction_Button(EditAction a, float h) : base(a, h) { }
        public EditorGUIElement_Single_EditAction_Button(EditAction a) : this(a, DEFAULT_HEIGHT) { }
    }
}