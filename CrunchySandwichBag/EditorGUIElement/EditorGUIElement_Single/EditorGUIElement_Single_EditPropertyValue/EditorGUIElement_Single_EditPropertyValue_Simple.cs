using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElement_Single_EditPropertyValue_Simple<T> : EditorGUIElement_Single_EditPropertyValue
    {
        protected abstract T DrawFieldInternal(Rect rect, T value);

        protected override bool DrawSingleInternal(Rect rect)
        {
            T old_value;

            if(GetEditPropertyValue().TryGetContents<T>(out old_value))
            {
                T new_value = DrawFieldInternal(rect, old_value);

                if(new_value.NotEqualsEX(old_value))
                    GetEditPropertyValue().SetContents(new_value);

                return true;
            }

            return false;
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple(EditProperty_Value p, float h) : base(p, h) { }
        public EditorGUIElement_Single_EditPropertyValue_Simple(EditProperty_Value p) : this(p, DEFAULT_HEIGHT) { }
    }
}