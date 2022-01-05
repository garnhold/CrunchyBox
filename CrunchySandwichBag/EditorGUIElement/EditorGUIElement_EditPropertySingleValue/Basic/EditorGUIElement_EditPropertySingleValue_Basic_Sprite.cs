using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(Sprite), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_Sprite : EditorGUIElement_EditPropertySingleValue_Basic<Sprite>
    {
        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 1.0f;
        }

        protected override Sprite DrawValueInternal(Rect rect, Sprite value)
        {
            Rect field_rect;

            rect.SplitByXRightOffset(64.0f, out field_rect, out rect);

            value = EditorGUIExtensions.ObjectField<Sprite>(field_rect, value);
            GUIExtensions.DrawSprite(rect, value);

            return value;
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_Sprite(EditProperty_Single_Value p) : base(p) { }
    }
}