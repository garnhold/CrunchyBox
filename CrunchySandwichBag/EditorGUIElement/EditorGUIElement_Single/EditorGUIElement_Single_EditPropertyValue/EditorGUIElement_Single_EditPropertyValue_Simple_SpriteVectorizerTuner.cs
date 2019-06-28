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
    [EditorGUIElementForType(typeof(SpriteVectorizerTuner), true)]
    public class EditorGUIElement_Single_EditPropertyValue_Simple_SpriteVectorizerTuner : EditorGUIElement_Single_EditPropertyValue_Simple<SpriteVectorizerTuner>
    {
        protected override SpriteVectorizerTuner DrawFieldInternal(Rect rect, GUIContent label, SpriteVectorizerTuner value)
        {
            Rect label_rect;
            Rect display_rect;
            Rect field_rect;
            Rect line_thickness_rect;
            Rect point_size_rect;

            Sprite sprite = value.GetSprite();
            float line_thickness = value.GetLineThickness();
            float point_size = value.GetPointSize();

            rect.SplitByXLeftOffset(EditorGUIUtility.labelWidth, out label_rect, out rect);
            rect.SplitByXRightPercent(0.65f, out display_rect, out rect);
            rect.SplitByYBottomOffset(DEFAULT_HEIGHT, out field_rect, out rect);
            rect.SplitByYBottomOffset(DEFAULT_HEIGHT, out line_thickness_rect, out rect);
            rect.SplitByYBottomOffset(DEFAULT_HEIGHT, out point_size_rect, out rect);

            GUI.Label(label_rect, label);
            sprite = (Sprite)EditorGUI.ObjectField(field_rect, sprite, typeof(Sprite), false);
            line_thickness = EditorGUI.Slider(line_thickness_rect, "Line Thickness", line_thickness, 0.0f, 5.0f);
            point_size = EditorGUI.Slider(point_size_rect, "Point Size", point_size, 0.0f, 10.0f);

            GUIExtensions.DrawSprite(display_rect, sprite, FilterMode.Point);

            GUI.color = Color.white;
            Vector2 divisor = sprite.GetTextureSize() / display_rect.size.GetMinComponent();
            SpriteVectorizer.Vectorize(sprite)
                .ConvertGrouped(l => l.Convert(p => p.GetInvertY().GetComponentDivide(divisor) + display_rect.center))
                .Process(p => GUIExtensions.DrawLoop(p, line_thickness, point_size));

            return new SpriteVectorizerTuner(sprite, line_thickness, point_size);
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_SpriteVectorizerTuner(EditProperty_Value s, float h) : base(s, h)
        {
        }

        public EditorGUIElement_Single_EditPropertyValue_Simple_SpriteVectorizerTuner(EditProperty_Value s) : this(s, EditorGUIElement_Single.DEFAULT_HEIGHT * 10.0f) { }
    }
}