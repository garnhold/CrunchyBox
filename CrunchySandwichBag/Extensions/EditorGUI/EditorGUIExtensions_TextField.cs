using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public string TextField(Rect rect, GUIContent label, string value)
        {
            return EditorGUI.TextField(rect, label, value).RemoveNonPrintable();
        }
    }
}