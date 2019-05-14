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
    public class EditorGUIElement_Foldout_EditPropertyValue<T> : EditorGUIElement_Foldout<T> where T : EditorGUIElement_Container
    {
        private EditProperty_Value edit_property_value;

        protected override void SetIsOpenInternal(bool is_open)
        {
            edit_property_value.SetContents(is_open);
        }

        protected override bool GetIsOpenInternal()
        {
            bool is_open;

            edit_property_value.TryGetContents<bool>(out is_open);
            return is_open;
        }

        public EditorGUIElement_Foldout_EditPropertyValue(EditProperty_Value p, string t, T c, float h) : base(t, c, h)
        {
            edit_property_value = p;
        }

        public EditorGUIElement_Foldout_EditPropertyValue(EditProperty_Value p, string t, T c) : this(p, t, c, EditorGUIElement_Single.DEFAULT_HEIGHT) { }
    }
}