using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Slider : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<float>
    {
        private float left_value;
        private float right_value;

        protected override float DrawBuiltInFieldInternal(Rect rect, GUIContent label, float value)
        {
            return EditorGUI.Slider(rect, GUIContent.none, value, left_value, right_value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Slider(EditProperty_Value s, float l, float r, float h) : base(s, h)
        {
            left_value = l;
            right_value = r;
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Slider(EditProperty_Value s, float l, float r) : this(s, l, r, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Slider(EditProperty_Value s, float r) : this(s, 0.0f, r) { }
    }
}