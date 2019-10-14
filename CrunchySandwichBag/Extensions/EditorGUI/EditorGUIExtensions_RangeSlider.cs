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
        static public FloatRange RangeSlider(Rect rect, GUIContent label, FloatRange value, FloatRange range)
        {
            float x1 = value.x1;
            float x2 = value.x2;

            EditorGUI.MinMaxSlider(rect, label, ref x1, ref x2, range.x1, range.x2);

            return new FloatRange(x1, x2);
        }
    }
}