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
    public class EditorGUIElement_ScrollBox_VerticalStrip : EditorGUIElement_ScrollBox<EditorGUIElement_Container_Auto_Simple_VerticalStrip>
    {
        public EditorGUIElement_ScrollBox_VerticalStrip(float h) : base(new EditorGUIElement_Container_Auto_Simple_VerticalStrip(), h) { }
    }
}