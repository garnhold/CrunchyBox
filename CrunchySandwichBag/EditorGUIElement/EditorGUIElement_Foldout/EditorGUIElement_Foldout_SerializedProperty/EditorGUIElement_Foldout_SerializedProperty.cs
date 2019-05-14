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
    public class EditorGUIElement_Foldout_SerializedProperty<T> : EditorGUIElement_Foldout<T> where T : EditorGUIElement_Container
    {
        private SerializedProperty property;

        protected override void SetIsOpenInternal(bool is_open)
        {
            property.boolValue = is_open;
        }

        protected override bool GetIsOpenInternal()
        {
            return property.boolValue;
        }

        public EditorGUIElement_Foldout_SerializedProperty(SerializedProperty p, string t, T c, float h) : base(t, c, h)
        {
            property = p;
        }

        public EditorGUIElement_Foldout_SerializedProperty(SerializedProperty p, string t, T c) : this(p, t, c, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}