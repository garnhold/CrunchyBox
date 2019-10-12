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
    public class EditorGUIElement_DropZone<T> : EditorGUIElement
    {
        private string label;

        private Predicate<T> predicate;
        private Process<IList<T>> process;

        protected override void DrawElementInternal(Rect view)
        {
            IList<T> dragged;

            GUIExtensions.DrawOutlinedRect(GetElementRect(), Color.gray);
            GUI.Label(GetElementRect(), label);   

            if (EditorGUIExtensions.DropZone(GetElementRect(), predicate, out dragged))
                process(dragged);
        }

        public EditorGUIElement_DropZone(string l, Predicate<T> pre, Process<IList<T>> pro)
        {
            label = l;

            predicate = pre;
            process = pro;
        }
    }
}