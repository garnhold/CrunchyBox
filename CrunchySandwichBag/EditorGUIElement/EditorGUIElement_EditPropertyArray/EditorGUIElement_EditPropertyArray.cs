using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public abstract class EditorGUIElement_EditPropertyArray : EditorGUIElement
    {
        private EditProperty_Array property;

        protected abstract void DrawArrayInternal(Rect rect, int array_size);

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            int array_size;

            if (property.TryGetNumberElements(out array_size))
                DrawArrayInternal(GetElementRect(), array_size);
            else
                GUI.Label(GetElementRect(), "(Non-Unified Array Length)");
        }

        public EditorGUIElement_EditPropertyArray(EditProperty_Array p)
        {
            property = p;
        }

        public EditProperty_Array GetProperty()
        {
            return property;
        }
    }
}