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
    public abstract class EditorGUIElement_EditPropertySingleValue_PopupEX<T> : EditorGUIElement_EditPropertySingleValue<T>
    {
        private string[] option_names;
        private List<T> option_accumulator;

        public abstract IEnumerable<T> GetOptions();

        protected override T DrawValueInternal(Rect rect, T value)
        {
            if (option_accumulator.Change(GetOptions()) || option_names == null)
                option_names = option_accumulator.Convert(o => o.IfNotNull(z => z.ToString(), "None")).ToArray();

            return option_accumulator.Get(
                EditorGUI.Popup(
                    rect,
                    option_accumulator.FindIndexOf(value),
                    option_names
                )
            );
        }

        public EditorGUIElement_EditPropertySingleValue_PopupEX(EditProperty_Single_Value p) : base(p)
        {
            option_accumulator = new List<T>();
        }
    }
}