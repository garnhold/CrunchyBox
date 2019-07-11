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
    public class EditorGUIElement_Process : EditorGUIElement
    {
        private Process<Rect> draw_process;
        private Process unwind_process;

        protected override void DrawElementInternal(Rect view)
        {
            draw_process(GetElementRect());
        }

        protected override void UnwindInternal()
        {
            if (unwind_process != null)
                unwind_process();
        }

        public EditorGUIElement_Process(Process<Rect> d, Process u)
        {
            draw_process = d;
            unwind_process = u;
        }

        public EditorGUIElement_Process(Process<Rect> d) : this(d, null) { }
    }
}