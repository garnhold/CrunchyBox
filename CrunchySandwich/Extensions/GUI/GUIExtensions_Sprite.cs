using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawSprite(Rect rect, Sprite sprite)
        {
            GUI.DrawTextureWithTexCoords(
                RectExtensions.CreateCenterRect(rect.center, sprite.GetTextureSize().GetFilledDimension(rect.size)), 
                sprite.texture, 
                sprite.GetNormalizedTextureRect()
            );
        }
    }
}