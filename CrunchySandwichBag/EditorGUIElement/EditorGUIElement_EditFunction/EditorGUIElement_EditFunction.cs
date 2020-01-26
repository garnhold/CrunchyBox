using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
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