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
    
    public class EditorGUIElement_Popup_SerializedProperty_ProcessOperation<T> : EditorGUIElement_Popup_SerializedProperty<T>
    {
        private Process<SerializedProperty, T> set_process;
        private Operation<T, SerializedProperty> get_process;

        public EditorGUIElement_Popup_SerializedProperty_ProcessOperation(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o, Process<SerializedProperty, T> sp, Operation<T, SerializedProperty> go, float h) : base(s, es, o, h)
        {
            set_process = sp;
            get_process = go;
        }

        public EditorGUIElement_Popup_SerializedProperty_ProcessOperation(SerializedProperty s, IEnumerable<T> es, Operation<string, T> o, Process<SerializedProperty, T> sp, Operation<T, SerializedProperty> go) : this(s, es, o, sp, go, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty_ProcessOperation(SerializedProperty s, IEnumerable<T> es, Process<SerializedProperty, T> sp, Operation<T, SerializedProperty> go) : this(s, es, e => e.ToStringEX(), sp, go) { }

        public override void SetSelectedElement(T element)
        {
            set_process(GetSerializedProperty(), element);
        }

        public override T GetSelectedElement()
        {
            return get_process(GetSerializedProperty());
        }
    }
}