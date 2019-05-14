﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIFragment_MouseCapture_Drag : EditorGUIFragment_MouseCapture
    {
        private Process<int, Vector2> process;

        private Vector2 offset;

        protected override void HandleMouseEvent(Rect rect, EventType type, Event vnt)
        {
            if (type == EventType.MouseDown)
                offset = rect.position - vnt.mousePosition;

            process(
                vnt.button,
                vnt.mousePosition + offset
            );
        }

        public EditorGUIFragment_MouseCapture_Drag(Process<int, Vector2> p)
        {
            process = p;
        }
    }
}