using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
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