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
    public abstract class EditorGUIElement_Single_EditPropertyValue : EditorGUIElement_Single
    {
        private EditProperty_Value edit_property_value;

        public EditorGUIElement_Single_EditPropertyValue(EditProperty_Value p, float h) : base(h)
        {
            edit_property_value = p;
        }

        public EditorGUIElement_Single_EditPropertyValue(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }

        public EditProperty_Value GetEditPropertyValue()
        {
            return edit_property_value;
        }
    }
}