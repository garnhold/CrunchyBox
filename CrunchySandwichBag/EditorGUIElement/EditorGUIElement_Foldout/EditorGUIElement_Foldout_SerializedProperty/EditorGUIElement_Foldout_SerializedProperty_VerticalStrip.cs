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
    public class EditorGUIElement_Foldout_SerializedProperty_VerticalStrip : EditorGUIElement_Foldout_SerializedProperty<EditorGUIElement_Container_Auto_Simple_VerticalStrip>
    {
        public EditorGUIElement_Foldout_SerializedProperty_VerticalStrip(SerializedProperty s, string t, float h) : base(s, t, new EditorGUIElement_Container_Auto_Simple_VerticalStrip(), h) { }
        public EditorGUIElement_Foldout_SerializedProperty_VerticalStrip(SerializedProperty s, string t) : this(s, t, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}