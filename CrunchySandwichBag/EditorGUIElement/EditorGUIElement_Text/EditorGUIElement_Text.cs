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

        protected override void DrawContentsInternal(Rect view)
        {
            GUI.Label(GetContentsRect(), text);
        }

        protected override float CalculateElementHeightInternal()
        {
            return text.GetNumberLines() * LINE_HEIGHT;
        }

        public EditorGUIElement_Text(string t)
        {
            text = t;
        }
    }
}