using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public bool ZoneButton(Rect rect)
        {
            return new GUIControl_MouseCapture().UpdateClick(rect);
        }

        static public bool ColorButton(Rect rect, Color color)
        {
            Rect inner_rect = rect.GetShrunk(1.0f);

            DrawRect(rect, Color.gray.GetBrightened(0.9f));
            DrawRect(inner_rect, Color.gray);
            DrawRect(inner_rect, color);

            return ZoneButton(rect);
        }

        static public bool TextureButton(Rect rect, Texture2D texture)
        {
            Rect inner_rect = rect.GetShrunk(1.0f);

            DrawRect(rect, Color.gray.GetBrightened(0.9f));
            DrawRect(inner_rect, Color.gray);
            GUI.DrawTexture(inner_rect, texture);

            return ZoneButton(rect);
        }

        static public bool SpriteButton(Rect rect, Sprite sprite)
        {
            Rect inner_rect = rect.GetShrunk(1.0f);

            DrawRect(rect, Color.gray.GetBrightened(0.9f));
            DrawRect(inner_rect, Color.gray);
            GUIExtensions.DrawSprite(inner_rect, sprite);

            return ZoneButton(rect);
        }
    }
}