using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public abstract class EditorGUIElement_EditPropertySingleValue_Basic<T> : EditorGUIElement_EditPropertySingleValue<T>
    {
        protected abstract T DrawValueInternal(Rect rect, T value);

        protected override void DrawUnifiedElementInternal(Rect rect, T old_value)
        {
            T new_value = DrawValueInternal(GetElementRect(), old_value);

            if (new_value.NotEqualsEX(old_value))
                GetProperty().SetContentValues(new_value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic(EditProperty_Single_Value p) : base(p) { }
    }
}