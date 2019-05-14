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
    public class EditorGUIElement_Single_Button : EditorGUIElement_Single
    {
        private string label;
        private Process process;

        private bool is_pressed;

        protected override bool DrawSingleInternal(Rect rect)
        {
            is_pressed = GUI.Button(rect, label);

            return true;
        }

        protected override void UnwindInternal()
        {
            if (is_pressed)
                process();
        }

        public EditorGUIElement_Single_Button(string l, Process p, float h) : base(h)
        {
            label = l;
            process = p;
        }

        public EditorGUIElement_Single_Button(string l, Process p) : this(l, p, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Single_Button(Process p) : this("", p) { }
    }
}