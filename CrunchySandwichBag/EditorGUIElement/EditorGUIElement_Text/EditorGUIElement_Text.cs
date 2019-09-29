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
    public class EditorGUIElement_Text : EditorGUIElement
    {
        private string text;

        protected override float DoPlanInternal()
        {
            return text.GetNumberLines() * LINE_HEIGHT;
        }

        protected override void DrawContentsInternal(Rect view)
        {
            GUI.Label(GetContentsRect(), text);
        }

        public EditorGUIElement_Text(string t)
        {
            text = t;
        }
    }
}