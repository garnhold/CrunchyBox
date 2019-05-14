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
    public abstract class EditorGUIElement_SerializedProperty : EditorGUIElement
    {
        private SerializedProperty serialized_property;

        public EditorGUIElement_SerializedProperty(SerializedProperty p)
        {
            serialized_property = p;
        }

        public SerializedProperty GetSerializedProperty()
        {
            return serialized_property;
        }
    }
}