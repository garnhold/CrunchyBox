using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    	[EditorGUIElementForType(typeof(bool), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Bool : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<bool>
    {
		protected override float DoPlanInternal()
		{
			return LINE_HEIGHT;
		}

        protected override bool DrawBuiltInInternal(Rect rect, GUIContent label, bool value)
        {
            return (bool)EditorGUI.Toggle(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Bool(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Color), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Color : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<Color>
    {
		protected override float DoPlanInternal()
		{
			return LINE_HEIGHT;
		}

        protected override Color DrawBuiltInInternal(Rect rect, GUIContent label, Color value)
        {
            return (Color)EditorGUI.ColorField(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Color(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Gradient), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Gradient : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<Gradient>
    {
		protected override float DoPlanInternal()
		{
			return LINE_HEIGHT;
		}

        protected override Gradient DrawBuiltInInternal(Rect rect, GUIContent label, Gradient value)
        {
            return (Gradient)EditorGUI.GradientField(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Gradient(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Bounds), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Bounds : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<Bounds>
    {
		protected override float DoPlanInternal()
		{
			return LINE_HEIGHT * 3.0f;
		}

        protected override Bounds DrawBuiltInInternal(Rect rect, GUIContent label, Bounds value)
        {
            return (Bounds)EditorGUI.BoundsField(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Bounds(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Rect), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Rect : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<Rect>
    {
		protected override float DoPlanInternal()
		{
			return LINE_HEIGHT;
		}

        protected override Rect DrawBuiltInInternal(Rect rect, GUIContent label, Rect value)
        {
            return (Rect)EditorGUI.RectField(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Rect(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Vector2), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Vector2 : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<Vector2>
    {
		protected override float DoPlanInternal()
		{
			return LINE_HEIGHT;
		}

        protected override Vector2 DrawBuiltInInternal(Rect rect, GUIContent label, Vector2 value)
        {
            return (Vector2)EditorGUI.Vector2Field(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Vector2(EditProperty_Single_Value p) : base(p) { }
    }

	[EditorGUIElementForType(typeof(Vector3), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Vector3 : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<Vector3>
    {
		protected override float DoPlanInternal()
		{
			return LINE_HEIGHT;
		}

        protected override Vector3 DrawBuiltInInternal(Rect rect, GUIContent label, Vector3 value)
        {
            return (Vector3)EditorGUI.Vector3Field(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Vector3(EditProperty_Single_Value p) : base(p) { }
    }

}

