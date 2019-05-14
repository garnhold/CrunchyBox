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
        static public T EnumPopup<T>(Rect rect, T selected)
        {
            return EditorGUI.EnumPopup(rect, selected.Convert<Enum>()).Convert<T>();
        }
    }
}