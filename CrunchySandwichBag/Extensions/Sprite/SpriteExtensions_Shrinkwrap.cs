using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public class SpriteExtensions_Shrinkwrap
    {
        static public void Shrinkwrap(this Sprite item)
        {
            Texture2D texture = item.texture.Sideload();
            RectI2 original = item.rect.GetRectI2();
            RectI2 shrunk = texture.ShrinkwrapRect(original);

            VectorF2 original_pixel_pivot = original.ConvertPercentPointToRangePoint(item.GetNormalizedPivot().GetVectorF2());
            VectorF2 shrunk_normalized_pivot = shrunk.ConvertRangePointToPercentPoint(original_pixel_pivot);

            Rect new_rect = shrunk.GetRect();
            Vector2 new_pivot = shrunk_normalized_pivot.GetVector2();

            item.ModifySprite(delegate (SerializedProperty property) {
                property.ForceProperty("m_Rect").rectValue = new_rect;

                property.ForceProperty("m_Pivot").vector2Value = new_pivot;
                property.ForceProperty("m_Alignment").intValue = (int)new_pivot.GetSpriteAlignment();
            });
        }
    }
}