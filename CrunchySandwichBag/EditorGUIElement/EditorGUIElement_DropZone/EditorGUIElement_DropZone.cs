using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Sandwich;

    public class EditorGUIElement_DropZone : EditorGUIElement
    {
        private string label;

        private Type type;
        private Process<Array> process;

        private bool is_dropped;
        private Array dragged;

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            GUIExtensions.DrawOutlinedRect(GetElementRect(), Color.gray);
            GUI.Label(GetElementRect(), label);

            is_dropped = EditorGUIExtensions.DropZone(GetElementRect(), type, out dragged);
        }

        protected override void UnwindInternal(int draw_id)
        {
            if (is_dropped)
                process(dragged);
        }

        public EditorGUIElement_DropZone(string l, Type t, Process<Array> pro)
        {
            label = l;

            type = t;
            process = pro;
        }
    }
}