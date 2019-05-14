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
    public class EditorGUIElement_Popup_SerializedProperty_Represented_Int<T> : EditorGUIElement_Popup_SerializedProperty_Represented<T, int>
    {
        public EditorGUIElement_Popup_SerializedProperty_Represented_Int(SerializedProperty s, IEnumerable<T> es, Operation<int, T> o1, Operation<string, T> o2, float h) : base(s, es, o1, o2, h) { }
        public EditorGUIElement_Popup_SerializedProperty_Represented_Int(SerializedProperty s, IEnumerable<T> es, Operation<int, T> o1, Operation<string, T> o2) : this(s, es, o1, o2, EditorGUIElement_Single_Text.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty_Represented_Int(SerializedProperty s, IEnumerable<T> es, Operation<int, T> o1) : this(s, es, o1, e => e.ToStringEX()) { }

        public override void SetSelectedElementSurrogate(int surrogate)
        {
            GetSerializedProperty().intValue = surrogate;
        }

        public override int GetSelectedElementSurrogate()
        {
            return GetSerializedProperty().intValue;
        }
    }
}