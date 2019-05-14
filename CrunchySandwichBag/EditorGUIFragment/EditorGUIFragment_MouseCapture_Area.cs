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
    public class EditorGUIFragment_MouseCapture_Area : EditorGUIFragment_MouseCapture
    {
        private Process<int, Vector2> process;

        protected override void HandleMouseEvent(Rect rect, EventType type, Event vnt)
        {
            process(
                vnt.button,
                (vnt.mousePosition - rect.min).BindBetween(Vector2.zero, rect.GetSize())
            );
        }

        public EditorGUIFragment_MouseCapture_Area(Process<int, Vector2> p)
        {
            process = p;
        }
    }
}