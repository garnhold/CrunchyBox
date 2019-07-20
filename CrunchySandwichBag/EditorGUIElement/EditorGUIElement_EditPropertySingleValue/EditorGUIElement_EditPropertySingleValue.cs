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
    public abstract class EditorGUIElement_EditPropertySingleValue<T> : EditorGUIElement
    {
        private EditProperty_Single_Value property;

        protected abstract T DrawValueInternal(Rect rect, T value);

        protected override void DrawElementInternal(Rect view)
        {
            T old_value;

            if (property.TryGetContentValues<T>(out old_value))
            {
                T new_value = DrawValueInternal(GetElementRect(), old_value);

                if (new_value.NotEqualsEX(old_value))
                    property.SetContentValues(new_value);
            }
            else
            {
                EditorGUI.LabelField(GetElementRect(), "(Non-Unified Value)");
            }
        }

        public EditorGUIElement_EditPropertySingleValue(EditProperty_Single_Value p)
        {
            property = p;
        }

        public EditProperty_Single_Value GetProperty()
        {
            return property;
        }
    }
}