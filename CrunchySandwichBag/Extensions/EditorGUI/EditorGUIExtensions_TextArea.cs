﻿using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public string TextArea(Rect rect, GUIContent label, string value, bool use_word_wrap)
        {
            Rect label_rect;
            GUIStyle style = new GUIStyle(GUI.skin.textArea) {
                wordWrap = use_word_wrap
            };

            rect.SplitByXLeftOffset(EditorGUIUtility.labelWidth, out label_rect, out rect);

            GUI.Label(label_rect, label);
            return EditorGUI.TextArea(rect, value, style).RemoveNonPrintable();
        }
        static public int CalculateTextAreaNumberLines(float width, string value, bool use_word_wrap)
        {
            if (use_word_wrap)
                value = GUI.skin.LayoutText(GUI.skin.textArea, value, width - EditorGUIUtility.labelWidth);

            return value.GetNumberLines().BindAbove(1);
        }
    }
}