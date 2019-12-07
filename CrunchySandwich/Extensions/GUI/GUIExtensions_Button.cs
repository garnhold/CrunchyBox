using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public bool ColorButton(Rect rect, Color color)
        {
            Rect inner_rect = rect.GetShrunk(1.0f);

            DrawRect(rect, Color.gray.GetBrightened(0.9f));
            DrawRect(inner_rect, Color.gray);
            DrawRect(inner_rect, color);

            return ClickZone(rect);
        }

        static public bool TextureButton(Rect rect, Texture2D texture)
        {
            Rect inner_rect = rect.GetShrunk(1.0f);

            DrawRect(rect, Color.gray.GetBrightened(0.9f));
            DrawRect(inner_rect, Color.gray);
            GUI.DrawTexture(inner_rect, texture);

            return ClickZone(rect);
        }

        static public bool SpriteButton(Rect rect, Sprite sprite)
        {
            Rect inner_rect = rect.GetShrunk(1.0f);

            DrawRect(rect, Color.gray.GetBrightened(0.9f));
            DrawRect(inner_rect, Color.gray);
            GUIExtensions.DrawSprite(inner_rect, sprite);

            return ClickZone(rect);
        }
    }
}