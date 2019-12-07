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
    
    public class EditorGUIElement_Single_SerializedProperty_ObjectField : EditorGUIElement_Single_SerializedProperty
    {
        protected override bool DrawSingleInternal(Rect rect)
        {
            EditorGUI.ObjectField(rect, GetSerializedProperty(), GUIContent.none);

            return true;
        }

        public EditorGUIElement_Single_SerializedProperty_ObjectField(SerializedProperty s, float h) : base(s, h) { }
        public EditorGUIElement_Single_SerializedProperty_ObjectField(SerializedProperty s) : this(s, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}