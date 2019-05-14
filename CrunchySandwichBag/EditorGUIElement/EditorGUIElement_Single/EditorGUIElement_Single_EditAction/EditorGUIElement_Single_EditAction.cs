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
    public abstract class EditorGUIElement_Single_EditAction : EditorGUIElement_Single
    {
        private EditAction edit_action;

        public EditorGUIElement_Single_EditAction(EditAction a, float h) : base(h)
        {
            edit_action = a;
        }

        public EditorGUIElement_Single_EditAction(EditAction a) : this(a, DEFAULT_HEIGHT) { }

        public EditAction GetEditAction()
        {
            return edit_action;
        }
    }
}