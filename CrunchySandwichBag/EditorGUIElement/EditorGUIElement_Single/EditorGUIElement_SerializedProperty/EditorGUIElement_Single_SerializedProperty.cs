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
    public abstract class EditorGUIElement_Single_SerializedProperty : EditorGUIElement_Single
    {
        private SerializedProperty serialized_property;

        public EditorGUIElement_Single_SerializedProperty(SerializedProperty s, float h) : base(h)
        {
            serialized_property = s;
        }

        public EditorGUIElement_Single_SerializedProperty(SerializedProperty s) : this(s, DEFAULT_HEIGHT) { }

        public SerializedProperty GetSerializedProperty()
        {
            return serialized_property;
        }
    }
}