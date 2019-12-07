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