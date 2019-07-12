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
        private AutoMultilineAttribute auto_multiline_attribute;

        protected override string DrawBuiltInInternal(Rect rect, GUIContent label, string value)
        {
            if (multiline_attribute != null)
                return EditorGUIExtensions.TextArea(rect, label, value);

            if (auto_multiline_attribute != null)
            {
                string new_value = EditorGUIExtensions.TextArea(rect, label, value);

                if (new_value.GetNumberLines() != value.GetNumberLines())
                    InvalidateHeight();

                return new_value;
            }

            return EditorGUI.TextField(rect, label, value);
        }

        protected override float CalculateElementHeightInternal()
        {
            if (multiline_attribute != null)
                return multiline_attribute.lines * LINE_HEIGHT;

            if(auto_multiline_attribute != null)
            {
                string value;

                if (GetProperty().TryGetContents<string>(out value))
                    return value.GetLines().Count() * LINE_HEIGHT;
            }

            return LINE_HEIGHT;
        }

        public EditorGUIElement_EditPropertyValue_BuiltIn_String(EditProperty_Value p) : base(p)
        {
            multiline_attribute = p.GetCustomAttributeOfType<MultilineAttribute>(true);
            auto_multiline_attribute = p.GetCustomAttributeOfType<AutoMultilineAttribute>(true);
        }
    }
}