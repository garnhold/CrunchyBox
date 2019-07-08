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
	[EditorGUIElementForType(typeof(bool), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Bool : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<bool>
    {
        protected override bool DrawBuiltInFieldInternal(Rect rect, GUIContent label, bool value)
        {
            return (bool)EditorGUI.Toggle(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Bool(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Bool(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(byte), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Byte : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<byte>
    {
        protected override byte DrawBuiltInFieldInternal(Rect rect, GUIContent label, byte value)
        {
            return (byte)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Byte(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Byte(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(short), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Short : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<short>
    {
        protected override short DrawBuiltInFieldInternal(Rect rect, GUIContent label, short value)
        {
            return (short)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Short(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Short(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(int), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Int : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<int>
    {
        protected override int DrawBuiltInFieldInternal(Rect rect, GUIContent label, int value)
        {
            return (int)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Int(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Int(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(long), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Long : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<long>
    {
        protected override long DrawBuiltInFieldInternal(Rect rect, GUIContent label, long value)
        {
            return (long)EditorGUI.LongField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Long(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Long(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(float), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Float : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<float>
    {
        protected override float DrawBuiltInFieldInternal(Rect rect, GUIContent label, float value)
        {
            return (float)EditorGUI.FloatField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Float(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Float(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(double), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Double : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<double>
    {
        protected override double DrawBuiltInFieldInternal(Rect rect, GUIContent label, double value)
        {
            return (double)EditorGUI.DoubleField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Double(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Double(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(string), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_String : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<string>
    {
        protected override string DrawBuiltInFieldInternal(Rect rect, GUIContent label, string value)
        {
            return (string)EditorGUI.TextField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_String(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_String(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Color), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Color : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<Color>
    {
        protected override Color DrawBuiltInFieldInternal(Rect rect, GUIContent label, Color value)
        {
            return (Color)EditorGUI.ColorField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Color(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Color(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Bounds), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Bounds : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<Bounds>
    {
        protected override Bounds DrawBuiltInFieldInternal(Rect rect, GUIContent label, Bounds value)
        {
            return (Bounds)EditorGUI.BoundsField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Bounds(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Bounds(EditProperty_Value p) : this(p, DEFAULT_HEIGHT * 3.0f) { }
    }

	[EditorGUIElementForType(typeof(Rect), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Rect : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<Rect>
    {
        protected override Rect DrawBuiltInFieldInternal(Rect rect, GUIContent label, Rect value)
        {
            return (Rect)EditorGUI.RectField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Rect(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Rect(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Vector2), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Vector2 : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<Vector2>
    {
        protected override Vector2 DrawBuiltInFieldInternal(Rect rect, GUIContent label, Vector2 value)
        {
            return (Vector2)EditorGUI.Vector2Field(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Vector2(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Vector2(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Vector3), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Vector3 : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<Vector3>
    {
        protected override Vector3 DrawBuiltInFieldInternal(Rect rect, GUIContent label, Vector3 value)
        {
            return (Vector3)EditorGUI.Vector3Field(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Vector3(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Vector3(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Enum), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Enum : EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn<Enum>
    {
        protected override Enum DrawBuiltInFieldInternal(Rect rect, GUIContent label, Enum value)
        {
            return (Enum)EditorGUI.EnumPopup(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Enum(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_BuiltIn_Enum(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

}

