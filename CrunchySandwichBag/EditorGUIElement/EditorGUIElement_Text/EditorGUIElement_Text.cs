using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElement_Text : EditorGUIElement
    {
        private string text;

        protected override float DoPlanInternal()
        {
            return text.GetNumberLines() * LINE_HEIGHT;
        }

        protected override void DrawContentsInternal(int draw_id, Rect view)
        {
            GUI.Label(GetContentsRect(), text);
        }

        public EditorGUIElement_Text(string t)
        {
            text = t;
        }
    }
}