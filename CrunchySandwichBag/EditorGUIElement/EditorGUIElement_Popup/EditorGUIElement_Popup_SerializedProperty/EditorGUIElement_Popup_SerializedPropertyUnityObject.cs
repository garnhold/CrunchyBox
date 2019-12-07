using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Popup_SerializedProperty_UnityObject<T> : EditorGUIElement_Popup_SerializedProperty<T> where T : UnityEngine.Object
    {
        public EditorGUIElement_Popup_SerializedProperty_UnityObject(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o, float h) : base(s, es, o, h) { }
        public EditorGUIElement_Popup_SerializedProperty_UnityObject(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o) : this(s, es, o, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty_UnityObject(SerializedProperty s, IEnumerable<T> es) : this(s, es, e => e.ToStringEX()) { }

        public override void SetSelectedElement(T element)
        {
            GetSerializedProperty().objectReferenceValue = element;
        }

        public override T GetSelectedElement()
        {
            return (T)GetSerializedProperty().objectReferenceValue;
        }
    }
}