using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public string TextField(Rect rect, GUIContent label, string value)
        {
            return EditorGUI.TextField(rect, label, value).RemoveNonPrintable();
        }
        static public string TextField(Rect rect, string value)
        {
            return EditorGUI.TextField(rect, value).RemoveNonPrintable();
        }
    }
}