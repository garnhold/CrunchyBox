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
    public class EditorGUIElement_ScrollBox_Overflow_VerticalStrip : EditorGUIElement_ScrollBox_Overflow<EditorGUIElement_Container_Auto_Simple_VerticalStrip>
    {
        public EditorGUIElement_ScrollBox_Overflow_VerticalStrip(float m) : base(new EditorGUIElement_Container_Auto_Simple_VerticalStrip(), m) { }
    }
}