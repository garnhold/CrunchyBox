using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElement_Button : EditorGUIElement
    {
        private string label;
        private Process process;

        private bool is_pressed;

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            is_pressed = GUI.Button(GetElementRect(), label);
        }

        protected override void UnwindInternal(int draw_id)
        {
            if (is_pressed)
                process();
        }

        public EditorGUIElement_Button(string l, Process p)
        {
            label = l;
            process = p;
        }

        public EditorGUIElement_Button(Process p) : this("", p) { }
    }
}