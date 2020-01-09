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
    
    public abstract class EditorGUIElement_EditPropertySingleValue<T> : EditorGUIElement
    {
        private EditProperty_Single_Value property;

        protected abstract void DrawUnifiedElementInternal(Rect rect, T old_value);

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            T old_value;

            if (property.TryGetContentValues<T>(out old_value, true))
            {
                DrawUnifiedElementInternal(GetElementRect(), old_value);
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