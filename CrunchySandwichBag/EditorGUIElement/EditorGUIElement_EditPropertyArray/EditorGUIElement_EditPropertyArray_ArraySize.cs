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
    
    public class EditorGUIElement_EditPropertyArray_ArraySize : EditorGUIElement_EditPropertyArray
    {
        private int new_array_size;

        protected override void DrawArrayInternal(Rect rect, int array_size)
        {
            new_array_size = EditorGUI.DelayedIntField(GetElementRect(), array_size);
        }

        protected override void UnwindInternal(int draw_id)
        {
            GetProperty().Resize(new_array_size);
        }

        public EditorGUIElement_EditPropertyArray_ArraySize(EditProperty_Array p) : base(p) { }
    }
}