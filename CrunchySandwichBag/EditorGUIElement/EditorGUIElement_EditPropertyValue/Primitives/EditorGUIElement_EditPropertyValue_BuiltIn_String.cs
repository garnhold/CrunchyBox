using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorGUIElementForType(typeof(string), true)]
    public class EditorGUIElement_EditPropertyValue_BuiltIn_String : EditorGUIElement_EditPropertyValue_BuiltIn<string>
    {
        private MultilineAttribute multiline_attribute;

        protected override string DrawBuiltInInternal(Rect rect, GUIContent label, string value)
        {
            if(multiline_attribute != null)
                return EditorGUIExtensions.TextArea(rect, label, value);

            return EditorGUI.TextField(rect, label, value);
        }

        protected override float CalculateElementHeightInternal()
        {
            return multiline_attribute.IfNotNull(a => a.lines, 1) * LINE_HEIGHT;
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_String(EditProperty_Value p) : base(p)
        {
            multiline_attribute = p.GetCustomAttributeOfType<MultilineAttribute>(true);
        }
    }
}