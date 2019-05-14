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
    public class EditorGUIElement_Single_Text : EditorGUIElement_Single
    {
        private string text;

        protected override bool DrawSingleInternal(Rect rect)
        {
            GUI.Label(rect, text);

            return true;
        }

        public EditorGUIElement_Single_Text(string t, float h) : base(h)
        {
            text = t;
        }

        public EditorGUIElement_Single_Text(string t) : this(t, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}