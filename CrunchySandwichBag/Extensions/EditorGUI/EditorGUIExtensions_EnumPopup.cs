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
        static public T EnumPopup<T>(Rect rect, T selected)
        {
            return EditorGUI.EnumPopup(rect, selected.Convert<Enum>()).Convert<T>();
        }
    }
}