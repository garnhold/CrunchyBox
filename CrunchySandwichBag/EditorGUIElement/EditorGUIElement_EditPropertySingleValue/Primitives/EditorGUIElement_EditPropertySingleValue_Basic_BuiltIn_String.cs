﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    [EditorGUIElementForType(typeof(string), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_String : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<string>
    {
        private bool use_word_wrap;

        private MultilineAttribute multiline_attribute;
        private AutoMultilineAttribute auto_multiline_attribute;

        private int CalculateNumberLines()
        {
            if (multiline_attribute != null)
                return multiline_attribute.lines;

            if (auto_multiline_attribute != null)
            {
                string value;

                if (GetProperty().TryGetContentValues<string>(out value))
                    return EditorGUIExtensions.CalculateTextAreaNumberLines(GetElementRect().width, value, use_word_wrap);
            }

            return 1;
        }

        protected override float DoPlanInternal()
        {
            return CalculateNumberLines() * LINE_HEIGHT;
        }

        protected override string DrawBuiltInInternal(Rect rect, GUIContent label, string value)
        {
            if (multiline_attribute != null)
                return EditorGUIExtensions.TextArea(rect, label, value, use_word_wrap);

            if (auto_multiline_attribute != null)
            {
                string new_value = EditorGUIExtensions.TextArea(rect, label, value, use_word_wrap);

                if (new_value != value)
                    Invalidate();

                return new_value;
            }

            return EditorGUIExtensions.TextField(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_String(EditProperty_Single_Value p) : base(p)
        {
            use_word_wrap = p.HasCustomAttributeOfType<WordWrapAttribute>(true);

            multiline_attribute = p.GetCustomAttributeOfType<MultilineAttribute>(true);
            auto_multiline_attribute = p.GetCustomAttributeOfType<AutoMultilineAttribute>(true);
        }
    }
}