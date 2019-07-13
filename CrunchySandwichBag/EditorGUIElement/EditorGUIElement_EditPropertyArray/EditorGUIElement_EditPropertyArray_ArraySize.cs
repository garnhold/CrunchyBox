﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_EditPropertyArray_ArraySize : EditorGUIElement_EditPropertyArray
    {
        private int new_array_size;

        protected override void DrawArrayInternal(Rect rect, int array_size)
        {
            new_array_size = EditorGUI.DelayedIntField(GetElementRect(), array_size);
        }

        protected override void UnwindInternal()
        {
            GetProperty().Resize(new_array_size);
        }

        public EditorGUIElement_EditPropertyArray_ArraySize(EditProperty_Array p) : base(p) { }
    }
}