using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElement_DropZone<T> : EditorGUIElement
    {
        private string label;

        private Predicate<T> predicate;
        private Process<IList<T>> process;

        private bool is_dropped;
        private IList<T> dragged;

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            GUIExtensions.DrawOutlinedRect(GetElementRect(), Color.gray);
            GUI.Label(GetElementRect(), label);

            is_dropped = EditorGUIExtensions.DropZone(GetElementRect(), predicate, out dragged);
        }

        protected override void UnwindInternal(int draw_id)
        {
            if (is_dropped)
                process(dragged);
        }

        public EditorGUIElement_DropZone(string l, Predicate<T> pre, Process<IList<T>> pro)
        {
            label = l;

            predicate = pre;
            process = pro;
        }
    }

    public class EditorGUIElement_DropZone : EditorGUIElement_DropZone<UnityEngine.Object>
    {
        public EditorGUIElement_DropZone(string l, Predicate<UnityEngine.Object> pre, Process<IList<UnityEngine.Object>> pro) : base(l, pre, pro) { }
    }
}