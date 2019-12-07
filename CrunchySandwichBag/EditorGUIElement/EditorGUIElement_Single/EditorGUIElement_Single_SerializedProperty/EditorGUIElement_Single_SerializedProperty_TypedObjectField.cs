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
    
    public class EditorGUIElement_Single_SerializedProperty_TypedObjectField : EditorGUIElement_Single_SerializedProperty
    {
        private Type type;

        protected override bool DrawSingleInternal(Rect rect)
        {
            UnityEngine.Object obj = EditorGUI.ObjectField(rect, GUIContent.none, GetSerializedProperty().objectReferenceValue, type, true);

            if (GetSerializedProperty().objectReferenceValue != obj)
                GetSerializedProperty().objectReferenceValue = obj;

            return true;
        }

        public EditorGUIElement_Single_SerializedProperty_TypedObjectField(SerializedProperty s, Type t, float h) : base(s, h)
        {
            type = t;
        }

        public EditorGUIElement_Single_SerializedProperty_TypedObjectField(SerializedProperty s, Type t) : this(s, t, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}