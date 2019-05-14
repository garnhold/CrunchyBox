using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorWindowEX_Simple : EditorWindowEX
    {
        protected abstract void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root);

        protected override EditorGUIElement CreateRootEditorGUIElement()
        {
            EditorGUIElement_Container_Auto_Simple_VerticalStrip root = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            InitilizeRootEditorGUIElement(root);
            return root;
        }
    }
}