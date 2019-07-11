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
    [EditorGUIElementForType(typeof(UnityEngine.Object), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_UnityObject : EditorGUIElement_EditPropertyValue_BuiltIn<UnityEngine.Object>
    {
        protected override UnityEngine.Object DrawBuiltInInternal(Rect rect, GUIContent label, UnityEngine.Object value)
        {
            return EditorGUI.ObjectField(rect, label, value, GetProperty().GetPropertyType());
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_UnityObject(EditProperty_Value p) : base(p) { }
    }
}