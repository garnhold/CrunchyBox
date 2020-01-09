using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_UnhandledEditProperty : EditorGUIElement
    {
        private EditProperty property;

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            GUI.Label(GetElementRect(), "--Unable to create GUI element for " + property + "--");
        }

        public EditorGUIElement_UnhandledEditProperty(EditProperty p)
        {
            property = p;
        }
    }
}