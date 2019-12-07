using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_Complex_SerializedProperty<T> : EditorGUIElement_Complex<T>
    {
        private SerializedProperty serialized_property;

        public EditorGUIElement_Complex_SerializedProperty(SerializedProperty s)
        {
            serialized_property = s;
        }

        public SerializedProperty GetSerializedProperty()
        {
            return serialized_property;
        }
    }
}