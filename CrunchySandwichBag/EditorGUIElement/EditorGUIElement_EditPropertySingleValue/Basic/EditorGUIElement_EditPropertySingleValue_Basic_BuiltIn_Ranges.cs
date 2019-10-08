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
	[EditorGUIElementForType(typeof(IntRange), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_IntRange : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<IntRange>
    {
        protected override IntRange DrawBuiltInInternal(Rect rect, GUIContent label, IntRange value)
        {
            Rect x1_rect;
            Rect x2_rect;

			rect.SplitByXCenter(out x1_rect, out x2_rect);

            int x1 = EditorGUI.IntField(x1_rect, label, value.x1);
            int x2 = EditorGUI.IntField(x2_rect, "->", value.x2);

            return new IntRange(x1, x2);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_IntRange(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(FloatRange), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_FloatRange : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<FloatRange>
    {
        protected override FloatRange DrawBuiltInInternal(Rect rect, GUIContent label, FloatRange value)
        {
            Rect x1_rect;
            Rect x2_rect;

			rect.SplitByXCenter(out x1_rect, out x2_rect);

            float x1 = EditorGUI.FloatField(x1_rect, label, value.x1);
            float x2 = EditorGUI.FloatField(x2_rect, "->", value.x2);

            return new FloatRange(x1, x2);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_FloatRange(EditProperty_Single_Value p) : base(p) { }
    }

}

