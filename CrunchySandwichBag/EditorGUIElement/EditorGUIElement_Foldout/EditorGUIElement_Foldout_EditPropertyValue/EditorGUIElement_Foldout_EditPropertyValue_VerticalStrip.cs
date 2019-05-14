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
    public class EditorGUIElement_Foldout_EditPropertyValue_VerticalStrip : EditorGUIElement_Foldout_EditPropertyValue<EditorGUIElement_Container_Auto_Simple_VerticalStrip>
    {
        public EditorGUIElement_Foldout_EditPropertyValue_VerticalStrip(EditProperty_Value s, string t, float h) : base(s, t, new EditorGUIElement_Container_Auto_Simple_VerticalStrip(), h) { }
        public EditorGUIElement_Foldout_EditPropertyValue_VerticalStrip(EditProperty_Value s, string t) : this(s, t, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}