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
    public abstract class EditorGUIElement_Single_EditPropertyArray : EditorGUIElement_Single
    {
        private EditProperty_Array edit_property_array;

        public EditorGUIElement_Single_EditPropertyArray(EditProperty_Array p, float h) : base(h)
        {
            edit_property_array = p;
        }

        public EditorGUIElement_Single_EditPropertyArray(EditProperty_Array p) : this(p, DEFAULT_HEIGHT) { }

        public EditProperty_Array GetEditPropertyArray()
        {
            return edit_property_array;
        }
    }
}