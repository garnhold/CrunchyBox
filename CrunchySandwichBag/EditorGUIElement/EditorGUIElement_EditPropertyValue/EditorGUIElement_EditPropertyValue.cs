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
    public abstract class EditorGUIElement_EditPropertyValue<T> : EditorGUIElement
    {
        private EditProperty_Value property;

        protected abstract T DrawValueInternal(Rect rect, T value);

        protected override void DrawElementInternal(Rect view)
        {
            T old_value;

            if (property.TryGetContents<T>(out old_value))
            {
                T new_value = DrawValueInternal(GetElementRect(), old_value);

                if (new_value.NotEqualsEX(old_value))
                    property.SetContents(new_value);
            }
            else
            {
                EditorGUI.LabelField(GetElementRect(), "--Disabled--");
            }
        }

        public EditorGUIElement_EditPropertyValue(EditProperty_Value p)
        {
            property = p;
        }

        public EditProperty_Value GetProperty()
        {
            return property;
        }
    }
}