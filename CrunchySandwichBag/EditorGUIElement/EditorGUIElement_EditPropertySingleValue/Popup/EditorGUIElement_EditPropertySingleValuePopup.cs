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
    public abstract class EditorGUIElement_EditPropertySingleValuePopup<T> : EditorGUIElement
    {
        private EditProperty_Single_Value property;

        public abstract IEnumerable<T> GetOptions();

        protected override void DrawElementInternal(Rect view)
        {
            T old_value;

            if (property.TryGetContentValues<T>(out old_value, true))
            {
                if (EditorGUIExtensions.DropdownButton(GetElementRect(), old_value.ToStringEX("None")))
                {
                    GenericMenuExtensions.Create<T>(GetOptions(), o => property.SetContentValues(o))
                        .DropDown(GetElementRect());
                }
            }
            else
            {
                EditorGUI.LabelField(GetElementRect(), "(Non-Unified Value)");
            }
        }

        public EditorGUIElement_EditPropertySingleValuePopup(EditProperty_Single_Value p)
        {
            property = p;
        }

        public EditProperty_Single_Value GetProperty()
        {
            return property;
        }
    }
}