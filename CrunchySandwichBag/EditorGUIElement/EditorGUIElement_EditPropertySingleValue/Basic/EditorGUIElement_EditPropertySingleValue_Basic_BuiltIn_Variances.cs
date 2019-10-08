using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
	[EditorGUIElementForType(typeof(IntVariance), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_IntVariance : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<IntVariance>
    {
        protected override IntVariance DrawBuiltInInternal(Rect rect, GUIContent label, IntVariance value)
        {
            Rect value_rect;
            Rect radius_rect;

			rect.SplitByXCenter(out value_rect, out radius_rect);

            int v = EditorGUI.IntField(value_rect, label, value.value);
            int r = EditorGUI.IntField(radius_rect, "\u00B1", value.radius);

            return new IntVariance(v, r);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_IntVariance(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(FloatVariance), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_FloatVariance : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<FloatVariance>
    {
        protected override FloatVariance DrawBuiltInInternal(Rect rect, GUIContent label, FloatVariance value)
        {
            Rect value_rect;
            Rect radius_rect;

			rect.SplitByXCenter(out value_rect, out radius_rect);

            float v = EditorGUI.FloatField(value_rect, label, value.value);
            float r = EditorGUI.FloatField(radius_rect, "\u00B1", value.radius);

            return new FloatVariance(v, r);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_FloatVariance(EditProperty_Single_Value p) : base(p) { }
    }

}

