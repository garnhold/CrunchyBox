﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_EditDisplay_Text : EditorGUIElement_EditDisplay
    {
        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 1.2f;
        }

        protected override void DrawElementInternal(Rect view)
        {
            object value;

            if (GetEditDisplay().TryGetValue(out value))
                EditorGUIExtensions.TextDisplay(GetElementRect(), value.ToStringEX());
            else
                EditorGUIExtensions.TextDisplay(GetElementRect(), "Non Unified Values");
        }

        public EditorGUIElement_EditDisplay_Text(EditDisplay d) : base(d) { }
    }
}