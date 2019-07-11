using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
	public abstract class EditorGUIElement_EditPropertyValue_BuiltIn_Number<T> : EditorGUIElement_EditPropertyValue_BuiltIn<T>
	{
		private RangeAttribute range_attribute;

		protected abstract T DrawNumberInternal(Rect rect, GUIContent label, T value);

		protected override T DrawBuiltInInternal(Rect rect, GUIContent label, T value)
		{
			if(range_attribute != null)
			{
				return EditorGUI.Slider(
					rect,
					label,
					value.ConvertEX<float>(),
					range_attribute.min, 
					range_attribute.max
				).ConvertEX<T>();
			}

            return DrawNumberInternal(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Number(EditProperty_Value p) : base(p)
		{
			range_attribute = p.GetCustomAttributeOfType<RangeAttribute>(true);
		}
	}

	[EditorGUIElementForType(typeof(byte), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Number_Byte : EditorGUIElement_EditPropertyValue_BuiltIn_Number<byte>
    {
        protected override byte DrawNumberInternal(Rect rect, GUIContent label, byte value)
        {
            return (byte)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_Number_Byte(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(short), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Number_Short : EditorGUIElement_EditPropertyValue_BuiltIn_Number<short>
    {
        protected override short DrawNumberInternal(Rect rect, GUIContent label, short value)
        {
            return (short)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_Number_Short(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(int), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Number_Int : EditorGUIElement_EditPropertyValue_BuiltIn_Number<int>
    {
        protected override int DrawNumberInternal(Rect rect, GUIContent label, int value)
        {
            return (int)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_Number_Int(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(long), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Number_Long : EditorGUIElement_EditPropertyValue_BuiltIn_Number<long>
    {
        protected override long DrawNumberInternal(Rect rect, GUIContent label, long value)
        {
            return (long)EditorGUI.LongField(rect, label, value);
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_Number_Long(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(float), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Number_Float : EditorGUIElement_EditPropertyValue_BuiltIn_Number<float>
    {
        protected override float DrawNumberInternal(Rect rect, GUIContent label, float value)
        {
            return (float)EditorGUI.FloatField(rect, label, value);
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_Number_Float(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(double), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Number_Double : EditorGUIElement_EditPropertyValue_BuiltIn_Number<double>
    {
        protected override double DrawNumberInternal(Rect rect, GUIContent label, double value)
        {
            return (double)EditorGUI.DoubleField(rect, label, value);
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_Number_Double(EditProperty_Value p) : base(p) { }
    }

}

