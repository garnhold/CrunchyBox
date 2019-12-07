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
    
    public abstract class EditorGUIElement_EditAction : EditorGUIElement
    {
        private EditAction edit_action;

        public EditorGUIElement_EditAction(EditAction a)
        {
            edit_action = a;
        }

        public EditAction GetEditAction()
        {
            return edit_action;
        }
    }
}