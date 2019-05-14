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
    public class EditorGUIElement_Single_EditPropertyValue_Simple_UnityObject : EditorGUIElement_Single_EditPropertyValue_Simple<UnityEngine.Object>
    {
        protected override UnityEngine.Object DrawFieldInternal(Rect rect, GUIContent label, UnityEngine.Object value)
        {
            return EditorGUI.ObjectField(rect, label, value, GetEditPropertyValue().GetPropertyType());
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_UnityObject(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple_UnityObject(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }
}