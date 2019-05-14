using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElement_Complex_EditPropertyValue<T> : EditorGUIElement_Complex<T>
    {
        private EditProperty_Value property;

        public EditorGUIElement_Complex_EditPropertyValue(EditProperty_Value p)
        {
            property = p;
        }

        public EditProperty_Value GetEditPropertyValue()
        {
            return property;
        }
    }
}