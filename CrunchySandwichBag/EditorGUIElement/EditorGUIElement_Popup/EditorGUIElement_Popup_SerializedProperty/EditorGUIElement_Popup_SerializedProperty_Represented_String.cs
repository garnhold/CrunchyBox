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
    public class EditorGUIElement_Popup_SerializedProperty_Represented_String<T> : EditorGUIElement_Popup_SerializedProperty_Represented<T, string>
    {
        public EditorGUIElement_Popup_SerializedProperty_Represented_String(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o1, Operation<string, T> o2, float h) : base(s, es, o1, o2, h) { }
        public EditorGUIElement_Popup_SerializedProperty_Represented_String(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o1, Operation<string, T> o2) : this(s, es, o1, o2, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty_Represented_String(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o1) : this(s, es, o1, o1) { }
        public EditorGUIElement_Popup_SerializedProperty_Represented_String(SerializedProperty s, IEnumerable<T> es) : this(s, es, e => e.ToStringEX()) { }

        public override void SetSelectedElementSurrogate(string surrogate)
        {
            GetSerializedProperty().stringValue = surrogate;
        }

        public override string GetSelectedElementSurrogate()
        {
            return GetSerializedProperty().stringValue;
        }
    }
}