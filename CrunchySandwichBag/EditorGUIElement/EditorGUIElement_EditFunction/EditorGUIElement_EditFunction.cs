using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElement_EditFunction : EditorGUIElement
    {
        private EditFunction edit_function;

        public EditorGUIElement_EditFunction(EditFunction f)
        {
            edit_function = f;
        }

        public EditFunction GetEditFunction()
        {
            return edit_function;
        }
    }
}