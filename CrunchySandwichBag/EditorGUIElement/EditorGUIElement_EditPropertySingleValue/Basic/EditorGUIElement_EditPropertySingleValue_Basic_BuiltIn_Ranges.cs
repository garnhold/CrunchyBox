using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(IntRange), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_IntRange : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<IntRange>
    {
		private RangeAttribute range_attribute;

        protected override IntRange DrawBuiltInInternal(Rect rect, GUIContent label, IntRange value)
        {
			if(range_attribute != null)
				return (IntRange)EditorGUIExtensions.RangeSlider(rect, label, (IntRange)value, new FloatRange(range_attribute.min, range_attribute.max));
			else
			{
				Rect x1_rect;
				Rect x2_rect;

				rect.SplitByXCenter(out x1_rect, out x2_rect);

				int x1 = EditorGUI.IntField(x1_rect, label, value.x1);
				int x2 = EditorGUI.IntField(x2_rect, "->", value.x2);

				return new IntRange(x1, x2);
			}
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_IntRange(EditProperty_Single_Value p) : base(p)
		{
			range_attribute = p.GetCustomAttributeOfType<RangeAttribute>(true);
		}
    }

	[EditorGUIElementForType(typeof(FloatRange), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_FloatRange : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<FloatRange>
    {
		private RangeAttribute range_attribute;

        protected override FloatRange DrawBuiltInInternal(Rect rect, GUIContent label, FloatRange value)
        {
			if(range_attribute != null)
				return (FloatRange)EditorGUIExtensions.RangeSlider(rect, label, (FloatRange)value, new FloatRange(range_attribute.min, range_attribute.max));
			else
			{
				Rect x1_rect;
				Rect x2_rect;

				rect.SplitByXCenter(out x1_rect, out x2_rect);

				float x1 = EditorGUI.FloatField(x1_rect, label, value.x1);
				float x2 = EditorGUI.FloatField(x2_rect, "->", value.x2);

				return new FloatRange(x1, x2);
			}
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_FloatRange(EditProperty_Single_Value p) : base(p)
		{
			range_attribute = p.GetCustomAttributeOfType<RangeAttribute>(true);
		}
    }

}

