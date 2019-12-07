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
        static public bool DropdownButton(Rect rect, string label)
        {
            return EditorGUI.DropdownButton(rect, new GUIContent(label), FocusType.Keyboard);
        }
    }
}