using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Single_SerializedProperty_Slider : EditorGUIElement_Single_SerializedProperty
    {
        private float left_value;
        private float right_value;

        protected override bool DrawSingleInternal(Rect rect)
        {
            EditorGUI.Slider(rect, GetSerializedProperty(), left_value, right_value, GUIContent.none);

            return true;
        }

        public EditorGUIElement_Single_SerializedProperty_Slider(SerializedProperty s, float l, float r, float h) : base(s, h)
        {
            left_value = l;
            right_value = r;
        }

        public EditorGUIElement_Single_SerializedProperty_Slider(SerializedProperty s, float l, float r) : this(s, l, r, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Single_SerializedProperty_Slider(SerializedProperty s, float r) : this(s, 0.0f, r) { }
    }
}