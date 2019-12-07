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
    
    public class EditorGUIElement_Popup_SerializedProperty_String : EditorGUIElement_Popup_SerializedProperty<string>
    {
        public EditorGUIElement_Popup_SerializedProperty_String(SerializedProperty s, IEnumerable<string> es, Operation<string, string> o, float h) : base(s, es, o, h) { }
        public EditorGUIElement_Popup_SerializedProperty_String(SerializedProperty s, IEnumerable<string> es, Operation<string, string> o) : this(s, es, o, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
        public EditorGUIElement_Popup_SerializedProperty_String(SerializedProperty s, IEnumerable<string> es) : this(s, es, e => e.ToStringEX()) { }

        public override void SetSelectedElement(string element)
        {
            GetSerializedProperty().stringValue = element;
        }

        public override string GetSelectedElement()
        {
            return GetSerializedProperty().stringValue;
        }
    }
}