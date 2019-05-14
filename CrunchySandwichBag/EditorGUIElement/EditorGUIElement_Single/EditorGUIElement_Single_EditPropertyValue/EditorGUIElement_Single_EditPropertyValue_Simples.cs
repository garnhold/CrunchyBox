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
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Bool : EditorGUIElement_Single_EditPropertyValue_Simple<bool>
    {
        protected override bool DrawFieldInternal(Rect rect, GUIContent label, bool value)
        {
            return (bool)EditorGUI.Toggle(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Bool(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Bool(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(byte), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Byte : EditorGUIElement_Single_EditPropertyValue_Simple<byte>
    {
        protected override byte DrawFieldInternal(Rect rect, GUIContent label, byte value)
        {
            return (byte)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Byte(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Byte(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(short), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Short : EditorGUIElement_Single_EditPropertyValue_Simple<short>
    {
        protected override short DrawFieldInternal(Rect rect, GUIContent label, short value)
        {
            return (short)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Short(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Short(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(int), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Int : EditorGUIElement_Single_EditPropertyValue_Simple<int>
    {
        protected override int DrawFieldInternal(Rect rect, GUIContent label, int value)
        {
            return (int)EditorGUI.IntField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Int(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Int(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(long), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Long : EditorGUIElement_Single_EditPropertyValue_Simple<long>
    {
        protected override long DrawFieldInternal(Rect rect, GUIContent label, long value)
        {
            return (long)EditorGUI.LongField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Long(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Long(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(float), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Float : EditorGUIElement_Single_EditPropertyValue_Simple<float>
    {
        protected override float DrawFieldInternal(Rect rect, GUIContent label, float value)
        {
            return (float)EditorGUI.FloatField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Float(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Float(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(double), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Double : EditorGUIElement_Single_EditPropertyValue_Simple<double>
    {
        protected override double DrawFieldInternal(Rect rect, GUIContent label, double value)
        {
            return (double)EditorGUI.DoubleField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Double(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Double(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(string), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_String : EditorGUIElement_Single_EditPropertyValue_Simple<string>
    {
        protected override string DrawFieldInternal(Rect rect, GUIContent label, string value)
        {
            return (string)EditorGUI.TextField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_String(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_String(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Color), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Color : EditorGUIElement_Single_EditPropertyValue_Simple<Color>
    {
        protected override Color DrawFieldInternal(Rect rect, GUIContent label, Color value)
        {
            return (Color)EditorGUI.ColorField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Color(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Color(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Bounds), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Bounds : EditorGUIElement_Single_EditPropertyValue_Simple<Bounds>
    {
        protected override Bounds DrawFieldInternal(Rect rect, GUIContent label, Bounds value)
        {
            return (Bounds)EditorGUI.BoundsField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Bounds(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Bounds(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Rect), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Rect : EditorGUIElement_Single_EditPropertyValue_Simple<Rect>
    {
        protected override Rect DrawFieldInternal(Rect rect, GUIContent label, Rect value)
        {
            return (Rect)EditorGUI.RectField(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Rect(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Rect(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Vector2), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Vector2 : EditorGUIElement_Single_EditPropertyValue_Simple<Vector2>
    {
        protected override Vector2 DrawFieldInternal(Rect rect, GUIContent label, Vector2 value)
        {
            return (Vector2)EditorGUI.Vector2Field(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Vector2(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Vector2(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Vector3), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Vector3 : EditorGUIElement_Single_EditPropertyValue_Simple<Vector3>
    {
        protected override Vector3 DrawFieldInternal(Rect rect, GUIContent label, Vector3 value)
        {
            return (Vector3)EditorGUI.Vector3Field(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Vector3(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Vector3(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

	[EditorGUIElementForType(typeof(Enum), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_Enum : EditorGUIElement_Single_EditPropertyValue_Simple<Enum>
    {
        protected override Enum DrawFieldInternal(Rect rect, GUIContent label, Enum value)
        {
            return (Enum)EditorGUI.EnumPopup(rect, label, value);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_Enum(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_Enum(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }

}

