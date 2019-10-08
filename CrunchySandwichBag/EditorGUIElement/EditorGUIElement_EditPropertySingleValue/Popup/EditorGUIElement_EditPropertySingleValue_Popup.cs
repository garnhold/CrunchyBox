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
    public abstract class EditorGUIElement_EditPropertySingleValue_Popup<T> : EditorGUIElement_EditPropertySingleValue<T>
    {
        public abstract IEnumerable<T> GetOptions();

        protected override void DrawUnifiedElementInternal(Rect rect, T old_value)
        {
            if (EditorGUIExtensions.DropdownButton(GetElementRect(), old_value.ToStringEX("None")))
            {
                List<T> options = GetOptions()
                    .Sort(o => o.ToStringEX())
                    .ToList();

                GenericMenuExtensions.Create<T>(options, o => GetProperty().SetContentValues(o))
                    .DropDown(GetElementRect());
            }
        }

        public EditorGUIElement_EditPropertySingleValue_Popup(EditProperty_Single_Value p) : base(p) { }
    }
}