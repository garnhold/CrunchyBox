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
            Texture2D texture = item.Sideload();
            RectI2 original = texture.GetRectI2();
            RectI2 shrunk = texture.ShrinkwrapRect(original);

            VectorF2 shrunk_pixel_pivot = shrunk.ConvertRangePointToPercentPoint(item.GetPixelPivot().GetVectorF2());

            item.ModifySprite(delegate (SerializedProperty property) {
                property.ForceProperty("m_Pivot").vector2Value = shrunk_pixel_pivot.GetVector2();
                property.ForceProperty("m_Rect").rectValue = shrunk.GetRect();
            });
        }
    }
}