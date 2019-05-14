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
    public abstract class EditorGUIElement_Popup_EditPropertyValue<T> : EditorGUIElement_Popup<T>
    {
        private EditProperty_Value property;

        public EditorGUIElement_Popup_EditPropertyValue(EditProperty_Value s, IEnumerable<T> es, Operation<string, T> o, float h) : base(es, o, h)
        {
            property = s;
        }

        public EditorGUIElement_Popup_EditPropertyValue(EditProperty_Value s, IEnumerable<T> es, Operation<string, T> o) : this(s, es, o, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_EditPropertyValue(EditProperty_Value s, IEnumerable<T> es) : this(s, es, e => e.ToStringEX()) { }

        public EditProperty_Value GetEditPropertyValue()
        {
            return property;
        }
    }
}