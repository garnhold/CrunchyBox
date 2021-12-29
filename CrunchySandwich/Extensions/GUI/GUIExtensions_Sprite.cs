using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public Rect DrawSprite(Rect rect, Sprite sprite)
        {
            if (sprite != null)
            {
                rect = RectExtensions.CreateCenterRect(rect.center, sprite.GetTextureSize().GetFilledDimension(rect.size));

                GUI.DrawTextureWithTexCoords(
                    rect,
                    sprite.texture,
                    sprite.GetNormalizedTextureRect()
                );
            }

            return rect;
        }
    }
}