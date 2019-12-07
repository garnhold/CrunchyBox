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
    
    public class EditorGUIElement_Popup_SerializedProperty_Int : EditorGUIElement_Popup_SerializedProperty<int>
    {
        public EditorGUIElement_Popup_SerializedProperty_Int(SerializedProperty s, IEnumerable<int> es, Operation<string, int> o, float h) : base(s, es, o, h) { }
        public EditorGUIElement_Popup_SerializedProperty_Int(SerializedProperty s, IEnumerable<int> es, Operation<string, int> o) : this(s, es, o, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty_Int(SerializedProperty s, IEnumerable<int> es) : this(s, es, e => e.ToStringEX()) { }

        public override void SetSelectedElement(int element)
        {
            GetSerializedProperty().intValue = element;
        }

        public override int GetSelectedElement()
        {
            return GetSerializedProperty().intValue;
        }
    }
}