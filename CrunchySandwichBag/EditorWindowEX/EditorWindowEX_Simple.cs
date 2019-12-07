using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
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