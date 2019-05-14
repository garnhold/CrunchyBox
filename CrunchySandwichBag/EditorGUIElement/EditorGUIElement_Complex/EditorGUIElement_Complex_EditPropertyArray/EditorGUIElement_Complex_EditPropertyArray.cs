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
    public abstract class EditorGUIElement_Complex_EditPropertyArray<T> : EditorGUIElement_Complex<T>
    {
        private EditProperty_Array property;

        public EditorGUIElement_Complex_EditPropertyArray(EditProperty_Array p)
        {
            property = p;
        }

        public EditProperty_Array GetEditPropertyArray()
        {
            return property;
        }
    }
}