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
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Bool : EditorGUIElement_EditPropertyValue_BuiltIn<bool>
    {
        protected override bool DrawBuiltInInternal(Rect rect, GUIContent label, bool value)
        {
            return (bool)EditorGUI.Toggle(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Bool(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Color), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Color : EditorGUIElement_EditPropertyValue_BuiltIn<Color>
    {
        protected override Color DrawBuiltInInternal(Rect rect, GUIContent label, Color value)
        {
            return (Color)EditorGUI.ColorField(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Color(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Bounds), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Bounds : EditorGUIElement_EditPropertyValue_BuiltIn<Bounds>
    {
        protected override Bounds DrawBuiltInInternal(Rect rect, GUIContent label, Bounds value)
        {
            return (Bounds)EditorGUI.BoundsField(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT * 3.0f;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Bounds(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Rect), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Rect : EditorGUIElement_EditPropertyValue_BuiltIn<Rect>
    {
        protected override Rect DrawBuiltInInternal(Rect rect, GUIContent label, Rect value)
        {
            return (Rect)EditorGUI.RectField(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Rect(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Vector2), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Vector2 : EditorGUIElement_EditPropertyValue_BuiltIn<Vector2>
    {
        protected override Vector2 DrawBuiltInInternal(Rect rect, GUIContent label, Vector2 value)
        {
            return (Vector2)EditorGUI.Vector2Field(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Vector2(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Vector3), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Vector3 : EditorGUIElement_EditPropertyValue_BuiltIn<Vector3>
    {
        protected override Vector3 DrawBuiltInInternal(Rect rect, GUIContent label, Vector3 value)
        {
            return (Vector3)EditorGUI.Vector3Field(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Vector3(EditProperty_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Enum), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_Enum : EditorGUIElement_EditPropertyValue_BuiltIn<Enum>
    {
        protected override Enum DrawBuiltInInternal(Rect rect, GUIContent label, Enum value)
        {
            return (Enum)EditorGUI.EnumPopup(rect, label, value);
        }

		protected override float CalculateElementHeightInternal()
		{
			return LINE_HEIGHT;
		}

        public EditorGUIElement_EditPropertyValue_BuiltIn_Enum(EditProperty_Value p) : base(p) { }
    }

}

