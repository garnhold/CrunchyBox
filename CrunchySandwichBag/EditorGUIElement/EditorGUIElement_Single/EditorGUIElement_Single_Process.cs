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
    public class EditorGUIElement_Single_Process : EditorGUIElement_Single
    {
        private Process<Rect> draw_process;
        private Process unwind_process;

        protected override bool DrawSingleInternal(Rect rect)
        {
            draw_process(rect);

            return true;
        }

        protected override void UnwindInternal()
        {
            if (unwind_process != null)
                unwind_process();
        }

        public EditorGUIElement_Single_Process(Process<Rect> d, Process u, float h) : base(h)
        {
            draw_process = d;
            unwind_process = u;
        }

        public EditorGUIElement_Single_Process(Process<Rect> d, Process u) : this(d, u, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Single_Process(Process<Rect> d) : this(d, null, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}