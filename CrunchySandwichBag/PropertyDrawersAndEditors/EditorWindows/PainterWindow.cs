using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class PainterWindow : EditorWindowEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root)
        {
            root.AddChild(new EditorGUIElement_Complex_All(Painter.GetInstance()));
        }
    }
}