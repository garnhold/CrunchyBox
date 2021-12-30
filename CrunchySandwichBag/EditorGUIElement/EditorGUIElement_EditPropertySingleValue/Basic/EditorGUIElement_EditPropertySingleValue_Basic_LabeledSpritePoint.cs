using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(LabeledSpritePoint), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_LabeledSpritePoint : EditorGUIElement_EditPropertySingleValue_Basic<LabeledSpritePoint>
    {
        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT * 8.0f;
        }

        protected override LabeledSpritePoint DrawValueInternal(Rect rect, LabeledSpritePoint value)
        {
            string label = value.GetLabel();
            Vector2 position = value.GetPosition();

            EditProperty_Single_Value sprite_property = GetProperty().GetTarget().ForcePropertyValue("target_asset");

            Rect label_rect;
            Rect position_rect;

            rect.SplitByXLeftPercent(0.4f, out rect, out position_rect);
            rect.SplitByYBottomOffset(LINE_HEIGHT, out label_rect, out rect);

            label = EditorGUIExtensions.TextField(label_rect, label);

            if (sprite_property != null)
            {
                Sprite sprite;

                if (sprite_property.TryGetContentValues<Sprite>(out sprite))
                {
                    position_rect = GUIExtensions.DrawSprite(position_rect, sprite);

                    position = EditorGUIExtensions.XYControl(
                        position_rect,
                        position,
                        new FloatRange(0.0f, 1.0f),
                        new FloatRange(0.0f, 1.0f)
                    );
                }
            }

            return new LabeledSpritePoint(label, position);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_LabeledSpritePoint(EditProperty_Single_Value p) : base(p) { }
    }
}