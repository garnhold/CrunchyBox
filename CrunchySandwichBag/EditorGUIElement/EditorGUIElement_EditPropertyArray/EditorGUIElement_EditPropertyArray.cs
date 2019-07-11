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
    public abstract class EditorGUIElement_EditPropertyArray : EditorGUIElement
    {
        private EditProperty_Array property;

        protected abstract void DrawArrayInternal(Rect rect, int array_size);

        protected override void DrawElementInternal(Rect view)
        {
            int array_size;

            if (property.TryGetNumberElements(out array_size))
            {
                DrawArrayInternal(GetElementRect(), array_size);
            }
            else
            {
                GUI.Label(GetElementRect(), "--Disabled--");
            }
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