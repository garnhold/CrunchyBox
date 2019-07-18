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
    public abstract class EditorGUIElement_EditPropertyValue_Popup<T> : EditorGUIElement_EditPropertyValue<T>
    {
        public abstract IEnumerable<T> GetOptions();

        protected override T DrawValueInternal(Rect rect, T value)
        {
            return EditorGUIExtensions.Popup(rect, value, GetOptions());
        }

        public EditorGUIElement_EditPropertyValue_Popup(EditProperty_Value p) : base(p) { }
    }
}