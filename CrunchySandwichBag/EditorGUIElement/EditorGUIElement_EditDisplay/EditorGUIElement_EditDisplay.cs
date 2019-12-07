using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_EditDisplay : EditorGUIElement
    {
        private EditDisplay edit_display;

        public EditorGUIElement_EditDisplay(EditDisplay d)
        {
            edit_display = d;
        }

        public EditDisplay GetEditDisplay()
        {
            return edit_display;
        }
    }
}