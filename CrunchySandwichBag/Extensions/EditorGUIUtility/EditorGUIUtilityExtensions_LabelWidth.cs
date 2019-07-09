using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class EditorGUIUtilityExtensions
    {
        static public void UseLabelWidth(float width, Process process)
        {
            float old_width = EditorGUIUtility.labelWidth;
            EditorGUIUtility.labelWidth = width;

            process();

            EditorGUIUtility.labelWidth = old_width;
        }
    }
}