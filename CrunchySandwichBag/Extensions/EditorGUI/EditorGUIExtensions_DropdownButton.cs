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
        static public bool DropdownButton(Rect rect, string label)
        {
            return EditorGUI.DropdownButton(rect, new GUIContent(label), FocusType.Keyboard);
        }
    }
}