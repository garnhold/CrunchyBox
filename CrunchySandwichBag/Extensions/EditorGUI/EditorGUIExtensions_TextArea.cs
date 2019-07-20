using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class EditorGUIExtensions
    {
        static public string TextArea(Rect rect, GUIContent label, string value)
        {
            Rect label_rect;

            rect.SplitByXLeftOffset(EditorGUIUtility.labelWidth, out label_rect, out rect);

            GUI.Label(label_rect, label);
            return EditorGUI.TextArea(rect, value).TrimTrailingWhitespace();
        }
    }
}