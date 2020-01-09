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
    
    public class EditorGUIElement_EditPropertyArray_FloatSequence : EditorGUIElement_EditPropertyArray
    {
        private float min_value;
        private float max_value;

        private Rect border_rect;
        private Rect background_rect;

        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 3.0f;
        }

        protected override Rect LayoutElementInternal(Rect rect)
        {
            border_rect = rect;
            background_rect = border_rect.GetShrunk(1.0f);

            return base.LayoutElementInternal(background_rect);
        }

        protected override void DrawArrayInternal(Rect rect, int array_size)
        {
            EditProperty_Array property = GetProperty();

            EditorGUI.DrawRect(border_rect, Color.black);
            EditorGUI.DrawRect(background_rect, Color.gray);

            float x = background_rect.xMin;
            float y = background_rect.yMax;

            float element_width = background_rect.width / array_size;
            float element_max_height = background_rect.height;

            for (int i = 0; i < array_size; i++)
            {
                float value;

                if (property.TryGetElementValue<float>(i, out value))
                {
                    float height = element_max_height * value.ConvertFromRangeToPercent(min_value, max_value);

                    EditorGUI.DrawRect(RectExtensions.CreateMinMaxRect(
                        new Vector2(x, y),
                        new Vector2(x + element_width, y - height)
                    ), Color.cyan);
                }

                x += element_width;
            }

            Vector2 percent;
            if (GUIExtensions.MousePercentArea(background_rect, out percent, true, true))
            {
                int index = (int)(array_size * percent.x);
                float magnitude = 1.0f - percent.y;

                if (property.IsIndexValid(index))
                    property.SetElementValue(index, magnitude.ConvertFromPercentToRange(min_value, max_value));
            }
        }

        public EditorGUIElement_EditPropertyArray_FloatSequence(EditProperty_Array p, float min, float max) : base(p)
        {
            min_value = min;
            max_value = max;
        }

        public EditorGUIElement_EditPropertyArray_FloatSequence(EditProperty_Array p, float max) : this(p, 0.0f, max) { }
        public EditorGUIElement_EditPropertyArray_FloatSequence(EditProperty_Array p) : this(p, 1.0f) { }
    }
}