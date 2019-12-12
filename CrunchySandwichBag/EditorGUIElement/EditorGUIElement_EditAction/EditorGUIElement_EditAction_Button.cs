using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_EditAction_Button : EditorGUIElement_EditAction
    {
        private bool is_pressed;

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            is_pressed = GUI.Button(GetElementRect(), GetEditAction().GetName().StyleEntityForDisplay());
        }

        protected override void UnwindInternal(int draw_id)
        {
            if (is_pressed)
                GetEditAction().Execute();
        }

        public EditorGUIElement_EditAction_Button(EditAction a) : base(a) { }
    }
}