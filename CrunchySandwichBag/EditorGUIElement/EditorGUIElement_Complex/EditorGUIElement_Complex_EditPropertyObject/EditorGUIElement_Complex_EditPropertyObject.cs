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
    public abstract class EditorGUIElement_Complex_EditPropertyObject<T> : EditorGUIElement_Complex<T>
    {
        private EditProperty_Object property;

        public EditorGUIElement_Complex_EditPropertyObject(EditProperty_Object p)
        {
            property = p;
        }

        public EditProperty_Object GetEditPropertyObject()
        {
            return property;
        }
    }
}