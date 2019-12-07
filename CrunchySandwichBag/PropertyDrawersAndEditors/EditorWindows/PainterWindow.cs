using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public class PainterWindow : EditorWindowEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root)
        {
            root.AddChild(new EditorGUIElement_Complex_All(Painter.GetInstance()));
        }
    }
}