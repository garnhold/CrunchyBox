using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawSprite(Rect rect, Sprite sprite)
        {
            if (sprite != null)
            {
                GUI.DrawTextureWithTexCoords(
                    RectExtensions.CreateCenterRect(rect.center, sprite.GetTextureSize().GetFilledDimension(rect.size)),
                    sprite.texture,
                    sprite.GetNormalizedTextureRect()
                );
            }
        }
    }
}