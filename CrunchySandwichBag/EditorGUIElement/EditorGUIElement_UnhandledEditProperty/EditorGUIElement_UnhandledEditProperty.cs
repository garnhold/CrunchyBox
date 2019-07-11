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
    public class EditorGUIElement_UnhandledEditProperty : EditorGUIElement
    {
        private EditProperty property;

        protected override void DrawElementInternal(Rect view)
        {
            GUI.Label(GetElementRect(), "--Unable to create GUI element for " + property + "--");
        }

        public EditorGUIElement_UnhandledEditProperty(EditProperty p)
        {
            property = p;
        }
    }
}