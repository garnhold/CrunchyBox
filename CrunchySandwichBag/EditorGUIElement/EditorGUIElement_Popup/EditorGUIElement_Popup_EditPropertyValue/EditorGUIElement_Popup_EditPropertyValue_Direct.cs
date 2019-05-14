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
    public class EditorGUIElement_Popup_EditPropertyValue_Direct<T> : EditorGUIElement_Popup_EditPropertyValue<T>
    {
        public EditorGUIElement_Popup_EditPropertyValue_Direct(EditProperty_Value s, IEnumerable<T> es, Operation<string, T> o, float h) : base(s, es, o, h) { }
        public EditorGUIElement_Popup_EditPropertyValue_Direct(EditProperty_Value s, IEnumerable<T> es, Operation<string, T> o) : this(s, es, o, DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_EditPropertyValue_Direct(EditProperty_Value s, IEnumerable<T> es) : this(s, es, e => e.ToStringEX()) { }

        public override void SetSelectedElement(T element)
        {
            GetEditPropertyValue().SetContents(element);
        }

        public override bool TryGetSelectedElement(out T element)
        {
            return GetEditPropertyValue().TryGetContents<T>(out element);
        }
    }
}