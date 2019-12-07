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
    
    public class EditorGUIElement_Single_SerializedProperty_ArraySize : EditorGUIElement_Single_SerializedProperty
    {
        private int new_array_size;

        protected override bool DrawSingleInternal(Rect rect)
        {
            new_array_size = EditorGUI.DelayedIntField(rect, GetSerializedProperty().GetArraySize());

            return true;
        }

        protected override void UnwindInternal()
        {
            GetSerializedProperty().SetArraySize(new_array_size);
        }

        public EditorGUIElement_Single_SerializedProperty_ArraySize(SerializedProperty s, float h) : base(s, h) { }
        public EditorGUIElement_Single_SerializedProperty_ArraySize(SerializedProperty s) : this(s, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}