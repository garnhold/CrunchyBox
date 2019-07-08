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
    public abstract class EditorGUIFragment_MouseCapture : EditorGUIFragment
    {
        private GUIControl_MouseCapture control;

        public EditorGUIFragment_MouseCapture()
        {
            control = new GUIControl_MouseCapture();
        }

        public GUIControl_MouseCapture GetControl()
        {
            return control;
        }
    }
}