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
    public class EditorGUIElement_Single_UnhandledEditProperty : EditorGUIElement_Single
    {
        private EditProperty property;

        protected override bool DrawSingleInternal(Rect rect)
        {
            GUI.Label(rect, "--Unable to create GUI element for " + property + "--");

            return true;
        }

        public EditorGUIElement_Single_UnhandledEditProperty(EditProperty p, float h) : base(h)
        {
            property = p;
        }

        public EditorGUIElement_Single_UnhandledEditProperty(EditProperty p) : this(p, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}