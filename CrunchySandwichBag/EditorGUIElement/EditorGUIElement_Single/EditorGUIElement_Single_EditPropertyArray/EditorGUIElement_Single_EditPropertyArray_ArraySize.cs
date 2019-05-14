using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Single_EditPropertyArray_ArraySize : EditorGUIElement_Single_EditPropertyArray
    {
        private int new_array_size;

        protected override bool DrawSingleInternal(Rect rect)
        {
            int old_array_size;

            if (GetEditPropertyArray().TryGetNumberElements(out old_array_size))
            {
                new_array_size = EditorGUI.DelayedIntField(rect, old_array_size);

                return true;
            }

            return false;
        }

        protected override void UnwindInternal()
        {
            GetEditPropertyArray().Resize(new_array_size);
        }

        public EditorGUIElement_Single_EditPropertyArray_ArraySize(EditProperty_Array p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyArray_ArraySize(EditProperty_Array p) : this(p, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}