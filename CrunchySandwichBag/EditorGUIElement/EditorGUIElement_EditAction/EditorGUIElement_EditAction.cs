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