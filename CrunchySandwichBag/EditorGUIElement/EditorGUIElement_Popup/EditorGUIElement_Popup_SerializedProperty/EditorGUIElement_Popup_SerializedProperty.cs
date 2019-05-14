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
    public abstract class EditorGUIElement_Popup_SerializedProperty<T> : EditorGUIElement_Popup<T>
    {
        private SerializedProperty serialized_property;

        public abstract T GetSelectedElement();

        public override bool TryGetSelectedElement(out T element)
        {
            element = GetSelectedElement();
            return true;
        }

        public EditorGUIElement_Popup_SerializedProperty(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o, float h) : base(es, o, h)
        {
            serialized_property = s;
        }

        public EditorGUIElement_Popup_SerializedProperty(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o) : this(s, es, o, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty(SerializedProperty s, IEnumerable<T> es) : this(s, es, e => e.ToStringEX()) { }

        public SerializedProperty GetSerializedProperty()
        {
            return serialized_property;
        }
    }
}